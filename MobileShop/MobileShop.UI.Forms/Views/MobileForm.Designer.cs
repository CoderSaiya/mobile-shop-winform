namespace MobileShop.UI.Forms.Views
{
    partial class MobileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblModel = new Label();
            cboModel = new ComboBox();
            lblImei = new Label();
            txtImei = new TextBox();
            lblWarranty = new Label();
            dtpWarranty = new DateTimePicker();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblName = new Label();
            txtName = new TextBox();
            lblImage = new Label();
            picMobile = new PictureBox();
            btnBrowse = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            //
            // lblModel
            //
            lblModel.AutoSize = true;
            lblModel.Location = new System.Drawing.Point(12, 15);
            lblModel.Text = "Model:";
            //
            // cboModel
            //
            cboModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModel.Location = new System.Drawing.Point(100, 12);
            cboModel.Size = new System.Drawing.Size(250, 28);
            //
            // lblImei
            //
            lblImei.AutoSize = true;
            lblImei.Location = new System.Drawing.Point(12, 55);
            lblImei.Text = "IMEI:";
            //
            // txtImei
            //
            txtImei.Location = new System.Drawing.Point(100, 52);
            txtImei.Size = new System.Drawing.Size(250, 27);
            //
            // lblWarranty
            //
            lblWarranty.AutoSize = true;
            lblWarranty.Location = new System.Drawing.Point(12, 135);
            lblWarranty.Text = "Warranty Until:";
            //
            // dtpWarranty
            //
            dtpWarranty.Format = DateTimePickerFormat.Short;
            dtpWarranty.Location = new System.Drawing.Point(130, 132);
            dtpWarranty.Size = new System.Drawing.Size(120, 27);
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(12, 175);
            lblPrice.Text = "Price:";
            //
            // numPrice
            //
            numPrice.Location = new System.Drawing.Point(100, 172);
            numPrice.DecimalPlaces = 2;
            numPrice.Maximum = 1000000000;
            numPrice.Size = new System.Drawing.Size(120, 27);
            // lblName
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 215);
            lblName.Text = "Name:";
            // txtName
            txtName.Location = new System.Drawing.Point(100, 212);
            txtName.Size = new System.Drawing.Size(250, 27);
            // lblImage
            lblImage.AutoSize = true;
            lblImage.Location = new System.Drawing.Point(380, 15);
            lblImage.Text = "Image:";
            //
            // picMobile
            //
            picMobile.BorderStyle = BorderStyle.FixedSingle;
            picMobile.Location = new System.Drawing.Point(380, 45);
            picMobile.Size = new System.Drawing.Size(200, 200);
            picMobile.SizeMode = PictureBoxSizeMode.Zoom;
            //
            // btnBrowse
            //
            btnBrowse.Location = new System.Drawing.Point(380, 255);
            btnBrowse.Size = new System.Drawing.Size(200, 27);
            btnBrowse.Text = "Browse Image...";
            btnBrowse.Click += BtnBrowse_Click;
            //
            // btnOK
            //
            btnOK.Location = new System.Drawing.Point(100, 255);
            btnOK.Size = new System.Drawing.Size(80, 30);
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Click += btnOK_Click;
            //
            // btnCancel
            //
            btnCancel.Location = new System.Drawing.Point(200, 255);
            btnCancel.Size = new System.Drawing.Size(80, 30);
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = DialogResult.Cancel;
            //
            // MobileForm
            //
            picMobile.Cursor = Cursors.Hand;
            picMobile.Click += BtnBrowse_Click;
            AcceptButton = btnOK;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(600, 360);
            Controls.Add(lblModel);
            Controls.Add(cboModel);
            Controls.Add(lblImei);
            Controls.Add(txtImei);
            Controls.Add(lblWarranty);
            Controls.Add(dtpWarranty);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblImage);
            Controls.Add(picMobile);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mobile";
        }

        #endregion

        private Label lblModel;
        private ComboBox cboModel;
        private Label lblImei;
        private TextBox txtImei;
        private Label lblWarranty;
        private DateTimePicker dtpWarranty;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblName;
        private TextBox txtName;
        private Label lblImage;
        private PictureBox picMobile;
        private Button btnBrowse;
        private Button btnOK;
        private Button btnCancel;
    }
}