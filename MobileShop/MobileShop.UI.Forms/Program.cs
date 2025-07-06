using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using MobileShop.UI.Forms.Views;

namespace MobileShop.UI.Forms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            Console.WriteLine("Database connected!");
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                "Không thể kết nối cơ sở dữ liệu:\n" + ex.Message,
                "Lỗi kết nối",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        Application.Run(new LoginForm());
    }
}