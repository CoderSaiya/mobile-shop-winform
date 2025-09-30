using System.ComponentModel;

namespace MobileShop.UI.Forms.Views;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        usernameTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
        passTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
        loginBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
        kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
        label4 = new Label();
        label5 = new Label();
        registLbl = new Label();
        pictureBox1 = new PictureBox();
        exitBox = new PictureBox();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)exitBox).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(64, 64, 64);
        label1.Location = new Point(730, 59);
        label1.Name = "label1";
        label1.Size = new Size(163, 36);
        label1.TabIndex = 3;
        label1.Text = "Đăng nhập";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.FromArgb(64, 64, 64);
        label2.Location = new Point(625, 157);
        label2.Name = "label2";
        label2.Size = new Size(89, 21);
        label2.TabIndex = 4;
        label2.Text = "Username";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(64, 64, 64);
        label3.Location = new Point(625, 257);
        label3.Name = "label3";
        label3.Size = new Size(82, 21);
        label3.TabIndex = 5;
        label3.Text = "Mật khẩu";
        // 
        // usernameTxt
        // 
        usernameTxt.Location = new Point(625, 192);
        usernameTxt.Name = "usernameTxt";
        usernameTxt.Size = new Size(363, 39);
        usernameTxt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
        usernameTxt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
        usernameTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
        usernameTxt.StateCommon.Border.Rounding = 18;
        usernameTxt.StateCommon.Content.Color1 = Color.Black;
        usernameTxt.StateCommon.Content.Font = new Font("Cambria", 10.2F);
        usernameTxt.TabIndex = 6;
        // 
        // passTxt
        // 
        passTxt.Location = new Point(625, 290);
        passTxt.Name = "passTxt";
        passTxt.Size = new Size(363, 39);
        passTxt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
        passTxt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
        passTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
        passTxt.StateCommon.Border.Rounding = 18;
        passTxt.StateCommon.Content.Color1 = Color.Black;
        passTxt.StateCommon.Content.Font = new Font("Cambria", 10.2F);
        passTxt.TabIndex = 7;
        passTxt.UseSystemPasswordChar = true;
        // 
        // loginBtn
        // 
        loginBtn.Location = new Point(708, 367);
        loginBtn.Name = "loginBtn";
        loginBtn.Size = new Size(219, 51);
        loginBtn.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
        loginBtn.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
        loginBtn.StateCommon.Back.ColorAngle = 45F;
        loginBtn.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
        loginBtn.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
        loginBtn.StateCommon.Border.ColorAngle = 45F;
        loginBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
        loginBtn.StateCommon.Border.Rounding = 18;
        loginBtn.StateCommon.Content.ShortText.Color1 = Color.White;
        loginBtn.StateCommon.Content.ShortText.Color2 = Color.White;
        loginBtn.StateCommon.Content.ShortText.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        loginBtn.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
        loginBtn.TabIndex = 8;
        loginBtn.Values.Text = "Đăng nhập";
        loginBtn.Click += LoginBtn_Click;
        // 
        // kryptonLabel1
        // 
        kryptonLabel1.Location = new Point(879, 463);
        kryptonLabel1.Name = "kryptonLabel1";
        kryptonLabel1.Size = new Size(6, 2);
        kryptonLabel1.TabIndex = 9;
        kryptonLabel1.Values.Text = "";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.FromArgb(64, 64, 64);
        label4.Location = new Point(741, 463);
        label4.Name = "label4";
        label4.Size = new Size(175, 20);
        label4.TabIndex = 10;
        label4.Text = "Bạn chưa có tài khoản?";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(64, 64, 64);
        label5.Location = new Point(741, 485);
        label5.Name = "label5";
        label5.Size = new Size(175, 20);
        label5.TabIndex = 10;
        label5.Text = "Xem danh sách thành viên";
        label5.Click += label5_Click;
        // 
        // registLbl
        // 
        registLbl.AutoSize = true;
        registLbl.Font = new Font("Cambria", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
        registLbl.ForeColor = Color.Blue;
        registLbl.Location = new Point(912, 463);
        registLbl.Name = "registLbl";
        registLbl.Size = new Size(67, 20);
        registLbl.TabIndex = 11;
        registLbl.Text = "Đăng ký";
        registLbl.Click += resgistLbl_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(34, 31);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(542, 493);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 12;
        pictureBox1.TabStop = false;
        // 
        // exitBox
        // 
        exitBox.Image = (Image)resources.GetObject("exitBox.Image");
        exitBox.Location = new Point(997, 12);
        exitBox.Name = "exitBox";
        exitBox.Size = new Size(25, 24);
        exitBox.SizeMode = PictureBoxSizeMode.Zoom;
        exitBox.TabIndex = 13;
        exitBox.TabStop = false;
        exitBox.Click += exitBox_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1034, 558);
        Controls.Add(exitBox);
        Controls.Add(pictureBox1);
        Controls.Add(registLbl);
        Controls.Add(label4);
        Controls.Add(label5);
        Controls.Add(kryptonLabel1);
        Controls.Add(loginBtn);
        Controls.Add(passTxt);
        Controls.Add(usernameTxt);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "x";
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)exitBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Label label2;
    private Label label3;
    private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTxt;
    private ComponentFactory.Krypton.Toolkit.KryptonTextBox passTxt;
    private ComponentFactory.Krypton.Toolkit.KryptonButton loginBtn;
    private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    private Label label4;
    private Label label5;
    private Label registLbl;
    private PictureBox pictureBox1;
    private PictureBox exitBox;
}