using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Windows.Forms;

namespace MobileShop.UI.Forms.Views
{
    partial class RegisterForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            loginLbl = new Label();
            label4 = new Label();
            registerBtn = new KryptonButton();
            passConfirmTxt = new KryptonTextBox();
            usernameTxt = new KryptonTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            passTxt = new KryptonTextBox();
            label6 = new Label();
            exitBox = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)exitBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(464, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Font = new Font("Cambria", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginLbl.ForeColor = Color.Blue;
            loginLbl.Location = new Point(316, 500);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(84, 20);
            loginLbl.TabIndex = 19;
            loginLbl.Text = "Đăng nhập";
            loginLbl.Click += loginLbl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(165, 500);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 18;
            label4.Text = "Bạn đã có tài khoản?";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(120, 404);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(219, 51);
            registerBtn.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            registerBtn.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
            registerBtn.StateCommon.Back.ColorAngle = 45F;
            registerBtn.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            registerBtn.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            registerBtn.StateCommon.Border.ColorAngle = 45F;
            registerBtn.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            registerBtn.StateCommon.Border.Rounding = 18;
            registerBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            registerBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            registerBtn.StateCommon.Content.ShortText.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            registerBtn.TabIndex = 17;
            registerBtn.Values.Text = "Đăng ký";
            registerBtn.Click += RegisterBtn_Click;
            // 
            // passConfirmTxt
            // 
            passConfirmTxt.Location = new Point(37, 327);
            passConfirmTxt.Name = "passConfirmTxt";
            passConfirmTxt.Size = new Size(363, 39);
            passConfirmTxt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            passConfirmTxt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            passConfirmTxt.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            passConfirmTxt.StateCommon.Border.Rounding = 18;
            passConfirmTxt.StateCommon.Content.Color1 = Color.Black;
            passConfirmTxt.StateCommon.Content.Font = new Font("Cambria", 10.2F);
            passConfirmTxt.TabIndex = 16;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(37, 138);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(363, 39);
            usernameTxt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            usernameTxt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            usernameTxt.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            usernameTxt.StateCommon.Border.Rounding = 18;
            usernameTxt.StateCommon.Content.Color1 = Color.Black;
            usernameTxt.StateCommon.Content.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(37, 294);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 14;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(37, 103);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(153, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 12;
            label1.Text = "Đăng ký";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(37, 228);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(363, 39);
            passTxt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            passTxt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            passTxt.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            passTxt.StateCommon.Border.Rounding = 18;
            passTxt.StateCommon.Content.Color1 = Color.Black;
            passTxt.StateCommon.Content.Font = new Font("Cambria", 10.2F);
            passTxt.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(37, 193);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 20;
            label6.Text = "Mật khẩu";
            // 
            // exitBox
            // 
            exitBox.Image = (Image)resources.GetObject("exitBox.Image");
            exitBox.Location = new Point(997, 12);
            exitBox.Name = "exitBox";
            exitBox.Size = new Size(25, 24);
            exitBox.SizeMode = PictureBoxSizeMode.Zoom;
            exitBox.TabIndex = 22;
            exitBox.TabStop = false;
            exitBox.Click += exitBox_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 558);
            Controls.Add(exitBox);
            Controls.Add(passTxt);
            Controls.Add(label6);
            Controls.Add(loginLbl);
            Controls.Add(label4);
            Controls.Add(registerBtn);
            Controls.Add(passConfirmTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)exitBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label loginLbl;
        private Label label4;
        private KryptonButton registerBtn;
        private KryptonTextBox passConfirmTxt;
        private KryptonTextBox usernameTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private KryptonTextBox passTxt;
        private Label label6;
        private PictureBox exitBox;
    }
}