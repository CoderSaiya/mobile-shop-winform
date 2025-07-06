namespace MobileShop.UI.Forms.Views
{
    partial class CompanyForm
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
            lblName = new Label();
            txtName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(110, 20);
            lblName.Text = "Company Name:";
            //
            // txtName
            //
            txtName.Location = new System.Drawing.Point(130, 12);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(240, 27);
            //
            // btnOK
            //
            btnOK.Location = new System.Drawing.Point(130, 55);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(80, 30);
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Click += btnOK_Click;
            //
            // btnCancel
            //
            btnCancel.Location = new System.Drawing.Point(230, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, 30);
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = DialogResult.Cancel;
            //
            // CompanyForm
            //
            AcceptButton = btnOK;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(392, 100);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Company";
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnOK;
        private Button btnCancel;
    }
}