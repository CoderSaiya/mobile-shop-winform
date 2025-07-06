using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using System.Data;

namespace MobileShop.UI.Forms.Views
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                using var da = new SqlDataAdapter(
                    "SELECT Username, EmployeeName, Address, MobileNumber, Role FROM tbl_User",
                    conn);
                var dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
                dgvUsers.Columns["Username"].HeaderText = "Tên đăng nhập";
                dgvUsers.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
                dgvUsers.Columns["Address"].HeaderText = "Địa chỉ";
                dgvUsers.Columns["MobileNumber"].HeaderText = "SĐT";
                dgvUsers.Columns["Role"].HeaderText = "Vai trò";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được danh sách user:\n{ex.Message}",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            var row = dgvUsers.SelectedRows[0];
            using var form = new UserForm(
                username: row.Cells["Username"].Value.ToString(),
                employeeName: row.Cells["EmployeeName"].Value.ToString(),
                address: row.Cells["Address"].Value.ToString(),
                mobileNumber: row.Cells["MobileNumber"].Value.ToString(),
                role: row.Cells["Role"].Value.ToString()
            );
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 user để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            var dr = MessageBox.Show($"Xác nhận xóa user '{username}'?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            using var conn = DbHelper.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM tbl_User WHERE Username = @u", conn);
            cmd.Parameters.AddWithValue("@u", username);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadUsers();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
