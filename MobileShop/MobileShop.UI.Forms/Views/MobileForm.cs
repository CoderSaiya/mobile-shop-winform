using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using System.Data;

namespace MobileShop.UI.Forms.Views
{
    public partial class MobileForm : Form
    {
        private readonly string? _originalImei;

        public MobileForm(string? imei = null, int? currentModelId = null,
                          string status = "", DateTime? warranty = null,
                          decimal price = 0)
        {
            InitializeComponent();
            LoadModels();

            _originalImei = imei;
            if (imei != null)
            {
                Text = "Edit Mobile";
                txtImei.Text = imei;
                txtImei.Enabled = false;
                cboModel.SelectedValue = currentModelId;
                txtStatus.Text = status;
                dtpWarranty.Value = warranty ?? DateTime.Today;
                numPrice.Value = price;
            }
            else
            {
                Text = "Add Mobile";
            }
        }

        private void LoadModels()
        {
            var dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter("SELECT ModelId, ModelNum FROM tbl_Model", conn);
            da.Fill(dt);
            cboModel.DataSource = dt;
            cboModel.DisplayMember = "ModelNum";
            cboModel.ValueMember = "ModelId";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedValue == null)
            {
                MessageBox.Show("Please select a model.");
                DialogResult = DialogResult.None;
                return;
            }
            var modelId = (int)cboModel.SelectedValue;
            var imei = txtImei.Text.Trim();
            if (string.IsNullOrEmpty(imei) || imei.Length != 15)
            {
                MessageBox.Show("Please enter a 15‑digit IMEI.");
                DialogResult = DialogResult.None;
                return;
            }
            var status = txtStatus.Text.Trim();
            var warranty = dtpWarranty.Value.Date;
            var price = numPrice.Value;
            var stock = numStock.Value;

            using var conn = DbHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            if (_originalImei != null)
            {
                cmd.CommandText = @"
                    UPDATE tbl_Mobile
                       SET ModelId = @m,
                           Status = @s,
                           Warranty= @w,
                           Price = @p,
                           Stock = @st
                     WHERE IMEINo  = @i";
                cmd.Parameters.AddWithValue("@i", _originalImei);
            }
            else
            {
                cmd.CommandText = @"
                    INSERT INTO tbl_Mobile
                           (ModelId, IMEINo, Status, Warranty, Price, Stock)
                    VALUES (@m, @i, @s, @w, @p, @st)";
                cmd.Parameters.AddWithValue("@i", imei);
            }
            cmd.Parameters.AddWithValue("@m", modelId);
            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@w", warranty);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@st", stock);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("This IMEI already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
