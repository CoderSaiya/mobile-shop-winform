using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;

namespace MobileShop.UI.Forms.Views
{
    public partial class UserForm : Form
    {
        private readonly bool _isEdit;
        private readonly string _originalUsername;

        public UserForm(string? username = null, string? employeeName = null,
                        string? address = null, string? mobileNumber = null,
                        string? role = null)
        {
            InitializeComponent();

            roleCbx.Items.Clear();
            roleCbx.Items.AddRange(new object[] { "Admin", "Customer" });

            if (!string.IsNullOrEmpty(username))
            {
                _isEdit = true;
                _originalUsername = username;
                Text = "Sửa User";

                usernameTxt.Text = username;
                usernameTxt.Enabled = false;
                employeeTxt.Text = employeeName ?? "";
                addressTxt.Text = address ?? "";
                mobileTxt.Text = mobileNumber ?? "";
                roleCbx.SelectedItem = role ?? "Customer";
            }
            else
            {
                _isEdit = false;
                Text = "Thêm User";
                roleCbx.SelectedItem = "Customer";
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text) ||
                string.IsNullOrWhiteSpace(employeeTxt.Text))
            {
                MessageBox.Show("Username, EmployeeName" +
                            (_isEdit ? "" : " và Password") +
                            " không được để trống.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            using var conn = DbHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            if (_isEdit)
            {
                cmd.CommandText = @"
                    UPDATE tbl_User
                       SET EmployeeName = @emp,
                           Address      = @addr,
                           MobileNumber = @mob,
                           Role         = @role
                     WHERE Username      = @u";
                cmd.Parameters.AddWithValue("@u", usernameTxt.Text.Trim());
            }
            else
            {
                string defaultHash = HashHelper.ComputeSha256Hash("123456");
                cmd.CommandText = @"
                    INSERT INTO tbl_User
                               (Username, PWO, EmployeeName, Address, MobileNumber, Role)
                    VALUES (@u, @p, @emp, @addr, @mob, @role)";
                cmd.Parameters.AddWithValue("@p", defaultHash);
            }

            cmd.Parameters.AddWithValue("@u", usernameTxt.Text.Trim());
            cmd.Parameters.AddWithValue("@emp", employeeTxt.Text.Trim());
            cmd.Parameters.AddWithValue("@addr", addressTxt.Text.Trim());
            cmd.Parameters.AddWithValue("@mob", mobileTxt.Text.Trim());
            cmd.Parameters.AddWithValue("@role", roleCbx.SelectedItem.ToString()!);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
            catch (SqlException ex) when (ex.Number == 2627) // duplicate key
            {
                MessageBox.Show("Một giá trị trùng lặp (username hoặc mobile) đã tồn tại.",
                        "Lỗi DUPLICATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

    }
}
