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
            usernameTxt = new System.Windows.Forms.TextBox();
            passwordTxt = new System.Windows.Forms.TextBox();
            employeeTxt = new System.Windows.Forms.TextBox();
            addressTxt = new System.Windows.Forms.TextBox();
            mobileTxt = new System.Windows.Forms.TextBox();
            roleCbx = new System.Windows.Forms.ComboBox();
            okBtn = new System.Windows.Forms.Button();
            cancelBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new System.Drawing.Point(20, 20);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new System.Drawing.Point(20, 60);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // employeeTxt
            // 
            employeeTxt.Location = new System.Drawing.Point(20, 100);
            employeeTxt.Name = "employeeTxt";
            employeeTxt.PlaceholderText = "Employee Name";
            employeeTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // addressTxt
            // 
            addressTxt.Location = new System.Drawing.Point(20, 140);
            addressTxt.Name = "addressTxt";
            addressTxt.PlaceholderText = "Address";
            addressTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // mobileTxt
            // 
            mobileTxt.Location = new System.Drawing.Point(20, 180);
            mobileTxt.Name = "mobileTxt";
            mobileTxt.PlaceholderText = "Mobile Number";
            mobileTxt.Size = new System.Drawing.Size(200, 27);
            // 
            // roleCbx
            // 
            roleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            roleCbx.Items.AddRange(new object[] { "Admin", "Customer" });
            roleCbx.Location = new System.Drawing.Point(20, 220);
            roleCbx.Name = "roleCbx";
            roleCbx.Size = new System.Drawing.Size(200, 28);
            // 
            // okBtn
            // 
            okBtn.Location = new System.Drawing.Point(20, 260);
            okBtn.Name = "okBtn";
            okBtn.Size = new System.Drawing.Size(90, 30);
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += new System.EventHandler(OkBtn_Click);
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new System.Drawing.Point(130, 260);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(90, 30);
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += (_, __) => DialogResult = DialogResult.Cancel;
            // 
            // UserForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(244, 320);
            Controls.Add(usernameTxt);
            Controls.Add(passwordTxt);
            Controls.Add(employeeTxt);
            Controls.Add(addressTxt);
            Controls.Add(mobileTxt);
            Controls.Add(roleCbx);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "UserForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
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