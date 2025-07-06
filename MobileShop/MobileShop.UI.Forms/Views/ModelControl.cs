using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using MySqlX.XDevAPI.Relational;
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
    public partial class ModelControl : UserControl
    {
        public ModelControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter(
                filter == ""
                ? "SELECT * FROM tbl_Model"
                : "SELECT * FROM tbl_Model WHERE ModelNum LIKE @f",
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
            using var form = new ModelForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var row = dataGridView.SelectedRows[0];
            int id = (int)row.Cells["ModelId"].Value;
            int comId = (int)row.Cells["ComId"].Value;
            string name = row.Cells["ModelNum"].Value.ToString()!;

            using var form = new ModelForm(id, comId, name);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var id = (int)dataGridView.SelectedRows[0].Cells["ModelId"].Value;
            if (MessageBox.Show("Delete this model?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using var conn = DbHelper.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM tbl_Model WHERE ModelId=@id", conn);
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
