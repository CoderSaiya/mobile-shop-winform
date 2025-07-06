using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using MobileShop.UI.Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MobileShop.UI.Forms.Views
{
    public partial class ConfirmPurchaseForm : MaterialForm
    {
        private readonly string _imei;
        private readonly string _model;
        private readonly decimal _price;

        public ConfirmPurchaseForm(string imei, string model, decimal price)
        {
            _imei = imei;
            _model = model;
            _price = price;

            ApplyMaterialSkin();
            InitializeComponent();
        }

        private void ApplyMaterialSkin()
        {
            var manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.Pink200,
                TextShade.WHITE);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var customer = new CustomerInfo(
                txtName.Text.Trim(),
                txtMobile.Text.Trim(),
                txtEmail.Text.Trim(),
                txtAddress.Text.Trim());

            var errors = Validate(customer);
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConfirmPurchase(_imei, _price, customer);
                MessageBox.Show("Purchase confirmed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during purchase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private List<string> Validate(CustomerInfo c)
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(c.Name))
                errors.Add("Customer name is required.");
            if (!string.IsNullOrWhiteSpace(c.Mobile) &&
                !Regex.IsMatch(c.Mobile, @"^(\+?[0-9]+)$"))
                errors.Add("Enter a valid mobile number.");
            if (!string.IsNullOrWhiteSpace(c.Email) &&
                !Regex.IsMatch(c.Email, @"^.+@.+\..+$"))
                errors.Add("Enter a valid email address.");
            return errors;
        }

        private static void ConfirmPurchase(string imei, decimal price, CustomerInfo c)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            // Upsert customer
            int custId;
            var upsertSql = @"
                IF NOT EXISTS (SELECT 1 FROM tbl_Customer 
                               WHERE MobileNumber=@mobile OR EmailId=@email)
                BEGIN
                    INSERT INTO tbl_Customer (Cust_Name, MobileNumber, EmailId, Address)
                    VALUES (@name, @mobile, @email, @address);
                    SELECT SCOPE_IDENTITY();
                END
                ELSE
                    SELECT CustId 
                    FROM tbl_Customer 
                    WHERE MobileNumber=@mobile OR EmailId=@email;
            ";
            using (var cmd = new SqlCommand(upsertSql, conn, tran))
            {
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@mobile", (object)c.Mobile ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@email", (object)c.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@address", (object)c.Address ?? DBNull.Value);
                custId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Update stock
            using (var cmd = new SqlCommand(
                "UPDATE tbl_Mobile SET Stock = Stock - 1 WHERE IMEINO = @imei AND Stock > 0",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@imei", imei);
                if (cmd.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("Không đủ hàng trong kho hoặc IMEI không tồn tại.");
            }

            // Insert sale
            using (var cmd = new SqlCommand(
                "INSERT INTO tbl_Sales (IMEINO, SalePrice, CustId) VALUES (@imei, @price, @custId)",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@imei", imei);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@custId", custId);
                cmd.ExecuteNonQuery();
            }

            // Insert transaction
            int modelId;
            using (var cmd = new SqlCommand(
                "SELECT ModelId FROM tbl_Mobile WHERE IMEINO = @imei",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@imei", imei);
                modelId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            using (var cmd = new SqlCommand(
                @"INSERT INTO tbl_Transaction (ModelId, Quantity, Amount)
                  VALUES (@modelId, 1, @amount)",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@modelId", modelId);
                cmd.Parameters.AddWithValue("@amount", price);
                cmd.ExecuteNonQuery();
            }


            tran.Commit();
        }
    }
}
