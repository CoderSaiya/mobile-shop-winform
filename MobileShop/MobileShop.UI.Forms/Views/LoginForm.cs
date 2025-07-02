using MaterialSkin;
using MaterialSkin.Controls;

namespace MobileShop.UI.Forms.Views;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
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
}