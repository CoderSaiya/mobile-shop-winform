namespace MobileShop.UI.Forms.Views
{
    partial class ModelForm
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
            this.lblCompany = new Label();
            this.cboCompany = new ComboBox();
            this.lblModelName = new Label();
            this.txtModelName = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();

            // lblCompany
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 15);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 20);
            this.lblCompany.Text = "Company:";

            // cboCompany
            this.cboCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCompany.Location = new System.Drawing.Point(110, 12);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(260, 28);

            // lblModelName
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(12, 55);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(96, 20);
            this.lblModelName.Text = "Model Name:";

            // txtModelName
            this.txtModelName.Location = new System.Drawing.Point(110, 52);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(260, 27);

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(110, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.Text = "OK";
            this.btnOK.DialogResult = DialogResult.OK;
            this.btnOK.Click += btnOK_Click;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(210, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.DialogResult = DialogResult.Cancel;

            // ModelForm
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 140);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Model";
        }

        #endregion

        private Label lblCompany;
        private ComboBox cboCompany;
        private Label lblModelName;
        private TextBox txtModelName;
        private Button btnOK;
        private Button btnCancel;
    }
}