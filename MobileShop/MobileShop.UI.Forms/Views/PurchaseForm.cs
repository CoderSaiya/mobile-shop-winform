using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using MobileShop.UI.Forms.ViewModels;

namespace MobileShop.UI.Forms.Views
{
    public partial class PurchaseForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;

        public PurchaseForm()
        {
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.Pink200,
                TextShade.WHITE);

            InitializeComponent();
            LoadAllPhones();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var imei = txtSearchImei.Text.Trim();
            if (imei.Length != 15)
            {
                MessageBox.Show("IMEI phải đủ 15 ký tự", "Lỗi IMEI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadPhones(imei, cbxStatusFilter.SelectedItem.ToString());
        }
        
        private void LoadAllPhones()
        {
            LoadPhones(null, cbxStatusFilter.SelectedItem.ToString());
        }
        
        private void LoadPhones(string imei, string statusFilter)
        {
            flpPhones.Controls.Clear();
            var list = new List<PhoneItem>();

            using var conn = DbHelper.GetConnection();
            conn.Open();
            var sql = @"
                SELECT m.IMEINO, mo.ModelNum, m.Status, m.Price, m.Image, m.Name
                FROM dbo.tbl_Mobile m
                JOIN dbo.tbl_Model mo ON m.ModelId = mo.ModelId";
            var conds = new List<string>();
            if (!string.IsNullOrEmpty(imei)) conds.Add("m.IMEINO = @imei");
            if (statusFilter != "All") conds.Add("m.Status = @status");
            if (conds.Count > 0) sql += " WHERE " + string.Join(" AND ", conds);

            using var cmd = new SqlCommand(sql, conn);
            if (!string.IsNullOrEmpty(imei)) cmd.Parameters.AddWithValue("@imei", imei);
            if (statusFilter != "All") cmd.Parameters.AddWithValue("@status", statusFilter);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new PhoneItem
                {
                    Imei = reader.GetString(0),
                    ModelNum = reader.GetString(1),
                    Status = reader.GetString(2),
                    Price = reader.GetDecimal(3),
                    Image = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Name = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                };
                list.Add(item);
            }

            foreach (var phone in list)
            {
                var card = CreatePhoneCard(phone);
                flpPhones.Controls.Add(card);
            }
        }

        private Panel CreatePhoneCard(PhoneItem phone)
        {
            var panel = new Panel
            {
                Width = 200,
                Height = 350,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            var pic = new PictureBox
            {
                Size = new Size(180, 180),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            if (!string.IsNullOrEmpty(phone.Image))
            {
                var path = Path.Combine(Application.StartupPath, "Resources", phone.Image);
                if (File.Exists(path)) pic.Image = Image.FromFile(path);
            }
            panel.Controls.Add(pic);

            panel.Controls.Add(new Label { Text = phone.ModelNum, Location = new Point(10, 200), AutoSize = true });
            panel.Controls.Add(new Label { Text = phone.Imei, Location = new Point(10, 220), AutoSize = true });
            panel.Controls.Add(new Label { Text = phone.Name, Location = new Point(10, 240), AutoSize = true });
            panel.Controls.Add(new Label { Text = $"Price: {phone.Price} VND", Location = new Point(10, 260), AutoSize = true });

            var btn = new MaterialButton
            {
                Text = "Sale",
                Location = new Point(50, 300),
                Size = new Size(100, 30),
                Enabled = phone.Status.Equals("Available", StringComparison.OrdinalIgnoreCase)
            };
            btn.Click += (s, e) => OnBuy(phone);
            panel.Controls.Add(btn);

            return panel;
        }
        
        private void OnBuy(PhoneItem phone)
        {
            using var dlg = new ConfirmPurchaseForm(phone.Imei, phone.ModelNum, phone.Price);
            if (dlg.ShowDialog() == DialogResult.OK)
                LoadAllPhones();
        }
    }
}
