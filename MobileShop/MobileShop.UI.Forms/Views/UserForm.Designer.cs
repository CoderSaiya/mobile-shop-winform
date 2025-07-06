namespace MobileShop.UI.Forms.Views
{
    partial class UserForm
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.employeeTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.roleCbx = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(20, 20);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(20, 60);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // employeeTxt
            // 
            this.employeeTxt.Location = new System.Drawing.Point(20, 100);
            this.employeeTxt.Name = "employeeTxt";
            this.employeeTxt.PlaceholderText = "Employee Name";
            this.employeeTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(20, 140);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PlaceholderText = "Address";
            this.addressTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // mobileTxt
            // 
            this.mobileTxt.Location = new System.Drawing.Point(20, 180);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.PlaceholderText = "Mobile Number";
            this.mobileTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // roleCbx
            // 
            this.roleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCbx.Items.AddRange(new object[] { "Admin", "Customer" });
            this.roleCbx.Location = new System.Drawing.Point(20, 220);
            this.roleCbx.Name = "roleCbx";
            this.roleCbx.Size = new System.Drawing.Size(200, 28);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(20, 260);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 30);
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(130, 260);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 30);
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += (_, __) => this.DialogResult = DialogResult.Cancel;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(244, 320);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.employeeTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.roleCbx);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private TextBox employeeTxt;
        private TextBox addressTxt;
        private TextBox mobileTxt;
        private ComboBox roleCbx;
        private Button okBtn;
        private Button cancelBtn;
    }
}