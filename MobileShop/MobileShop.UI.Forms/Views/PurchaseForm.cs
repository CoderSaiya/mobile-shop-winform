using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;

namespace MobileShop.UI.Forms.Views
{
    public partial class PurchaseForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;

        public PurchaseForm()
        {
            var manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.Pink200,
                TextShade.WHITE);

            InitializeComponent();
            LayoutControls();
        }

        private void LayoutControls()
        {
            txtSearchImei.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string imei = txtSearchImei.Text.Trim();
            if (imei.Length != 15)
            {
                MessageBox.Show("Enter valid 15-digit IMEI.", "Invalid IMEI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dt = new System.Data.DataTable();
            using var conn = DbHelper.GetConnection();
            using (var da = new SqlDataAdapter(
                "SELECT IMEINO,ModelNum,Status,Price FROM tbl_Mobile m JOIN tbl_Model mo ON m.ModelId=mo.ModelId WHERE IMEINO=@imei", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@imei", imei);
                da.Fill(dt);
            }
            dgvStock.DataSource = dt;
            lblStock.Text = $"Stock: {dt.Rows.Count}";
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            var row = dgvStock.SelectedRows[0];
            var imei = row.Cells["IMEINO"].Value.ToString();
            var model = row.Cells["ModelNum"].Value.ToString();
            var price = Convert.ToDecimal(row.Cells["Price"].Value);
            using (var dlg = new ConfirmPurchaseForm(imei, model, price))
                if (dlg.ShowDialog() == DialogResult.OK)
                    BtnSearch_Click(null, null);
        }
    }
}
