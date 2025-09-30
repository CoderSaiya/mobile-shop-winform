using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using System.Data;

namespace MobileShop.UI.Forms.Views
{
    public partial class MobileForm : Form
    {
        private readonly string? _originalImei;

        public MobileForm(string? imei = null, int? currentModelId = null,
            DateTime? warranty = null,
            decimal price = 0, string? name = null, string? imagePath = null)
        {
            InitializeComponent();
            LoadModels();

            _originalImei = imei;
            if (imei != null)
            {
                Text = "Edit Mobile";
                txtImei.Text = imei;
                txtImei.Enabled = false;
                cboModel.SelectedValue = currentModelId;
                dtpWarranty.Value = warranty ?? DateTime.Today;
                numPrice.Value = price;
                txtName.Text = name;
                if (!string.IsNullOrEmpty(imagePath))
                {
                    var file = Path.GetFileName(imagePath);
                    picMobile.Tag = file;
                    var full = Path.Combine(Application.StartupPath, "Resources", file);
                    if (File.Exists(full)) picMobile.Image = Image.FromFile(full);
                }
            }
            else
            {
                Text = "Add Mobile";
            }
        }

        private void LoadModels()
        {
            var dt = new System.Data.DataTable();
            using var conn = DbHelper.GetConnection();
            using var da = new SqlDataAdapter("SELECT ModelId, ModelNum FROM tbl_Model", conn);
            da.Fill(dt);
            cboModel.DisplayMember = "ModelNum";
            cboModel.ValueMember = "ModelId";
            cboModel.DataSource = dt;
        }
        
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            var resources = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            Directory.CreateDirectory(resources);
            var fileNameOnly = Path.GetFileName(dlg.FileName);
            var dest = Path.Combine(resources, fileNameOnly);
            File.Copy(dlg.FileName, dest, true);
            picMobile.Image = Image.FromFile(dest);
            picMobile.Tag = fileNameOnly;
            picMobile.ImageLocation = dest;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedValue == null)
            {
                MessageBox.Show("Please select a model.");
                DialogResult = DialogResult.None;
                return;
            }
            var modelId = (int)cboModel.SelectedValue;
            var imei = txtImei.Text.Trim();
            if (imei.Length != 15)
            {
                MessageBox.Show("Please enter a 15‑digit IMEI.");
                DialogResult = DialogResult.None;
                return;
            }
            var warranty = dtpWarranty.Value.Date;
            var price = numPrice.Value;
            var name = txtName.Text.Trim();
            var imageFile = picMobile.Tag as string;

            using var conn = DbHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            if (_originalImei != null)
            {
                cmd.CommandText = @"
                    UPDATE tbl_Mobile
                       SET ModelId=@m, Warranty=@w, Price=@p, Name=@n, Image=@img
                     WHERE IMEINo=@i";
                cmd.Parameters.AddWithValue("@i", _originalImei);
            }
            else
            {
                cmd.CommandText = @"
                    INSERT INTO tbl_Mobile(ModelId, IMEINo, Warranty, Price, Name, Image)
                    VALUES(@m,@i,@w,@p,@n,@img)";
                cmd.Parameters.AddWithValue("@i", imei);
            }
            cmd.Parameters.AddWithValue("@m", modelId);
            cmd.Parameters.AddWithValue("@w", warranty);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@n", name);
            if (string.IsNullOrEmpty(imageFile))
                cmd.Parameters.Add("@img", SqlDbType.NVarChar, 256).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@img", SqlDbType.NVarChar, 256).Value = imageFile;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("This IMEI already exists.");
                DialogResult = DialogResult.None;
            }
        }
    }
}
