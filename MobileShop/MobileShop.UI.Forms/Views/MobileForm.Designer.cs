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
            this.lblModel = new Label();
            this.cboModel = new ComboBox();
            this.lblImei = new Label();
            this.txtImei = new TextBox();
            this.lblStatus = new Label();
            this.txtStatus = new TextBox();
            this.lblWarranty = new Label();
            this.dtpWarranty = new DateTimePicker();
            this.lblPrice = new Label();
            this.numPrice = new NumericUpDown();
            this.lblStock = new Label();
            this.numStock = new NumericUpDown();
            this.btnOK = new Button();
            this.btnCancel = new Button();

            // lblModel
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 15);
            this.lblModel.Text = "Model:";

            // cboModel
            this.cboModel.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboModel.Location = new System.Drawing.Point(100, 12);
            this.cboModel.Size = new System.Drawing.Size(250, 28);

            // lblImei
            this.lblImei.AutoSize = true;
            this.lblImei.Location = new System.Drawing.Point(12, 55);
            this.lblImei.Text = "IMEI:";

            // txtImei
            this.txtImei.Location = new System.Drawing.Point(100, 52);
            this.txtImei.Size = new System.Drawing.Size(250, 27);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 95);
            this.lblStatus.Text = "Status:";

            // txtStatus
            this.txtStatus.Location = new System.Drawing.Point(100, 92);
            this.txtStatus.Size = new System.Drawing.Size(250, 27);

            // lblWarranty
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(12, 135);
            this.lblWarranty.Text = "Warranty Until:";

            // dtpWarranty
            this.dtpWarranty.Format = DateTimePickerFormat.Short;
            this.dtpWarranty.Location = new System.Drawing.Point(130, 132);
            this.dtpWarranty.Size = new System.Drawing.Size(120, 27);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 175);
            this.lblPrice.Text = "Price:";

            // numPrice
            this.numPrice.Location = new System.Drawing.Point(100, 172);
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Maximum = 1000000000;
            this.numPrice.Size = new System.Drawing.Size(120, 27);

            // lblStock
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 215);
            this.lblStock.Text = "Price:";

            // numStock
            this.numStock.Location = new System.Drawing.Point(100, 212);
            this.numStock.DecimalPlaces = 2;
            this.numStock.Maximum = 1000000000;
            this.numStock.Size = new System.Drawing.Size(120, 27);

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(100, 255);
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.Text = "OK";
            this.btnOK.DialogResult = DialogResult.OK;
            this.btnOK.Click += btnOK_Click;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 255);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.DialogResult = DialogResult.Cancel;

            // MobileForm
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.lblImei);
            this.Controls.Add(this.txtImei);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.dtpWarranty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Mobile";
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