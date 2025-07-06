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
            lblStatus = new Label();
            txtStatus = new TextBox();
            lblWarranty = new Label();
            dtpWarranty = new DateTimePicker();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblStock = new Label();
            numStock = new NumericUpDown();
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
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(12, 95);
            lblStatus.Text = "Status:";
            //
            // txtStatus
            //
            txtStatus.Location = new System.Drawing.Point(100, 92);
            txtStatus.Size = new System.Drawing.Size(250, 27);
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
            //
            // lblStock
            //
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(12, 215);
            lblStock.Text = "Price:";
            //
            // numStock
            //
            numStock.Location = new System.Drawing.Point(100, 212);
            numStock.DecimalPlaces = 2;
            numStock.Maximum = 1000000000;
            numStock.Size = new System.Drawing.Size(120, 27);
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
            AcceptButton = btnOK;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(380, 300);
            Controls.Add(lblModel);
            Controls.Add(cboModel);
            Controls.Add(lblImei);
            Controls.Add(txtImei);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(lblWarranty);
            Controls.Add(dtpWarranty);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblStock);
            Controls.Add(numStock);
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
        private Label lblStatus;
        private TextBox txtStatus;
        private Label lblWarranty;
        private DateTimePicker dtpWarranty;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblStock;
        private NumericUpDown numStock;
        private Button btnOK;
        private Button btnCancel;
    }
}