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
using static Jenga.Theme;

namespace MobileShop.UI.Forms.Views
{
    public partial class MobileControl : UserControl
    {
        public MobileControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter(
                filter == ""
                ? "SELECT * FROM tbl_Mobile"
                : "SELECT * FROM tbl_Mobile WHERE IMEINo LIKE @f",
                conn);
            if (filter != "")
                da.SelectCommand.Parameters.AddWithValue("@f", $"%{filter}%");

            var dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnSearch_Click(object sender, EventArgs e) =>
            LoadData(txtFilter.Text.Trim());

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new MobileForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var row = dataGridView.SelectedRows[0];
            string imeiNo = row.Cells["IMEINO"].Value.ToString()!;
            int currentModelId = (int)row.Cells["ModelId"].Value;
            string status = row.Cells["Status"].Value.ToString()!;
            DateTime warranty = (DateTime)row.Cells["Warranty"].Value;
            decimal price = (decimal)row.Cells["Price"].Value;

            using var form = new MobileForm(imeiNo, currentModelId, status, warranty, price);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var imei = dataGridView.SelectedRows[0].Cells["IMEINo"].Value.ToString();
            if (MessageBox.Show($"Delete mobile {imei}?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using var conn = DbHelper.GetConnection();
            using var cmd = new SqlCommand(
                "DELETE FROM tbl_Mobile WHERE IMEINo=@imei", conn);
            cmd.Parameters.AddWithValue("@imei", imei);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
