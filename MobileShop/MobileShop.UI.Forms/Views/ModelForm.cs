using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.UI.Forms.Views
{
    public partial class ModelForm : Form
    {
        private readonly int? _modelId;

        public ModelForm(int? modelId = null, int? currentCompanyId = null, string currentModelName = "")
        {
            InitializeComponent();
            _modelId = modelId;
            LoadCompanies();

            if (modelId.HasValue)
            {
                Text = "Edit Model";
                cboCompany.SelectedValue = currentCompanyId;
                txtModelName.Text = currentModelName;
            }
            else
            {
                Text = "Add Model";
                cboCompany.SelectedIndex = 0;
            }
        }

        private void LoadCompanies()
        {
            var dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter("SELECT ComId, CName FROM tbl_Company", conn);
            da.Fill(dt);
            cboCompany.DataSource = dt;
            cboCompany.DisplayMember = "CName";
            cboCompany.ValueMember = "ComId";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboCompany.SelectedValue == null)
            {
                MessageBox.Show("Please select a company.");
                DialogResult = DialogResult.None;
                return;
            }
            var companyId = (int)cboCompany.SelectedValue;
            var modelName = txtModelName.Text.Trim();
            if (string.IsNullOrEmpty(modelName))
            {
                MessageBox.Show("Please enter model name.");
                DialogResult = DialogResult.None;
                return;
            }

            using var conn = DbHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            if (_modelId.HasValue)
            {
                cmd.CommandText = @"
                    UPDATE tbl_Model
                       SET ComId = @com, ModelNum = @name
                     WHERE ModelId = @id";
                cmd.Parameters.AddWithValue("@id", _modelId.Value);
            }
            else
            {
                cmd.CommandText = @"
                    INSERT INTO tbl_Model (ComId, ModelNum)
                    VALUES (@com, @name)";
            }

            cmd.Parameters.AddWithValue("@com", companyId);
            cmd.Parameters.AddWithValue("@name", modelName);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("A model with that name already exists for this company.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
