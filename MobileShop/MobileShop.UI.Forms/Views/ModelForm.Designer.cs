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
            lblCompany = new Label();
            cboCompany = new ComboBox();
            lblModelName = new Label();
            txtModelName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            //
            // lblCompany
            //
            lblCompany.AutoSize = true;
            lblCompany.Location = new System.Drawing.Point(12, 15);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(80, 20);
            lblCompany.Text = "Company:";
            //
            // cboCompany
            //
            cboCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCompany.Location = new System.Drawing.Point(110, 12);
            cboCompany.Name = "cboCompany";
            cboCompany.Size = new System.Drawing.Size(260, 28);
            //
            // lblModelName
            //
            lblModelName.AutoSize = true;
            lblModelName.Location = new System.Drawing.Point(12, 55);
            lblModelName.Name = "lblModelName";
            lblModelName.Size = new System.Drawing.Size(96, 20);
            lblModelName.Text = "Model Name:";
            //
            // txtModelName
            //
            txtModelName.Location = new System.Drawing.Point(110, 52);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new System.Drawing.Size(260, 27);
            //
            // btnOK
            //
            btnOK.Location = new System.Drawing.Point(110, 95);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(80, 30);
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Click += btnOK_Click;
            //
            // btnCancel
            //
            btnCancel.Location = new System.Drawing.Point(210, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, 30);
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = DialogResult.Cancel;
            //
            // ModelForm
            //
            AcceptButton = btnOK;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(384, 140);
            Controls.Add(lblCompany);
            Controls.Add(cboCompany);
            Controls.Add(lblModelName);
            Controls.Add(txtModelName);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Model";
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