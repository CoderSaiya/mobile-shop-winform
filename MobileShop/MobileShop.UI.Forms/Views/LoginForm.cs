using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;

namespace MobileShop.UI.Forms.Views;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
        string username = usernameTxt.Text.Trim();
        string password = passTxt.Text; // chưa hash

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                            "Thiếu thông tin",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using var conn = DbHelper.GetConnection();
            using var cmd = new SqlCommand(
                "SELECT PWO, EmployeeName, Role FROM tbl_User WHERE Username = @u", conn);
            cmd.Parameters.AddWithValue("@u", username);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string storedHash = reader.GetString(0);
            string employeeName = reader.GetString(1);
            string role = reader.GetString(2);

            string incomingHash = HashHelper.ComputeSha256Hash(password);

            if (!string.Equals(storedHash, incomingHash, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Mật khẩu không chính xác.",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                var adminForm = new MainForm();
                adminForm.Show();
            }
            else
            {
                var purchaseForm = new PurchaseForm();
                purchaseForm.Show();
            }
            this.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi kết nối: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    private void resgistLbl_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm();

        registerForm.FormClosed += (s, args) =>
        {
            this.Show();
        };

        registerForm.Show();
        this.Hide();
    }

    private void exitBox_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
    
    private void label5_Click(object sender, EventArgs e)
    {
        var memberForm = new MemberForm();

        memberForm.FormClosed += (s, args) =>
        {
            this.Show();
        };

        memberForm.Show();
    }
}