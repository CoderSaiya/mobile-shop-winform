using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;

namespace MobileShop.UI.Forms.Views
{
    public partial class CompanyForm : Form
    {
        private readonly int? _companyId;

        public CompanyForm(int? companyId = null, string currentName = "")
        {
            InitializeComponent();
            _companyId = companyId;
            if (companyId.HasValue)
            {
                this.Text = "Edit Company";
                txtName.Text = currentName;
            }
            else
            {
                this.Text = "Add Company";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a company name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            using var conn = DbHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            if (_companyId.HasValue)
            {
                cmd.CommandText = "UPDATE tbl_Company SET CName = @name WHERE ComId = @id";
                cmd.Parameters.AddWithValue("@id", _companyId.Value);
            }
            else
            {
                cmd.CommandText = "INSERT INTO tbl_Company (CName) VALUES (@name)";
            }
            cmd.Parameters.AddWithValue("@name", name);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Company name already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }
        }

    }
}
