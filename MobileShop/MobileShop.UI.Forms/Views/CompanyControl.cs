using MobileShop.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jenga.Theme;

namespace MobileShop.UI.Forms.Views
{
    public partial class CompanyControl : UserControl
    {
        public CompanyControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter(
                filter == ""
                ? "SELECT * FROM tbl_Company"
                : "SELECT * FROM tbl_Company WHERE CName LIKE @f",
                conn);
            if (filter != "")
                da.SelectCommand.Parameters.AddWithValue("@f", $"%{filter}%");

            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnSearch_Click(object sender, EventArgs e) =>
            LoadData(txtFilter.Text.Trim());

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new CompanyForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["ComId"].Value;
            string currentName = row.Cells["CName"].Value.ToString()!;

            using var form = new CompanyForm(id, currentName);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var id = (int)dataGridView1.SelectedRows[0].Cells["ComId"].Value;
            if (MessageBox.Show("Delete this company?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using var conn = DbHelper.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM tbl_Company WHERE ComId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
