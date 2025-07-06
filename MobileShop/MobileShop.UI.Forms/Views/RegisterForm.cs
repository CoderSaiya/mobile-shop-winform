using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;

namespace MobileShop.UI.Forms.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string pwd = passTxt.Text;
            string confirm = passConfirmTxt.Text;
            
            if (username == "")
            {
                MessageBox.Show("Username không được để trống.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pwd.Length < 6)
            {
                MessageBox.Show("Mật khẩu ít nhất 6 ký tự.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pwd != confirm)
            {
                MessageBox.Show("Mật khẩu và xác nhận không khớp.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string hashed = HashHelper.ComputeSha256Hash(pwd);
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var tran = conn.BeginTransaction();

                using var cmd = new SqlCommand(@"
                    INSERT INTO dbo.tbl_User
                      (Username, PWO, EmployeeName, Address, MobileNumber, Hint)
                    VALUES
                      (@u, @p, @empName, @addr, @mob, NULL);
                ", conn, tran);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", hashed);
                cmd.Parameters.AddWithValue("@empName", username);
                cmd.Parameters.AddWithValue("@addr", "");
                cmd.Parameters.AddWithValue("@mob", "0");

                cmd.ExecuteNonQuery();
                tran.Commit();

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Username đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();

            loginForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            loginForm.Show();
            this.Hide();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
