using System.ComponentModel;
using System.Windows.Forms;

namespace MobileShop.UI.Forms.Views;

partial class MainForm
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
        components = new Container();
        Panel panel5;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
        exitBox = new PictureBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        panel1 = new Panel();
        companyTab = new Button();
        panel2 = new Panel();
        modelTab = new Button();
        panel3 = new Panel();
        mobileTab = new Button();
        menuContainer = new FlowLayoutPanel();
        salesTab = new Button();
        byDateSubTab = new Button();
        ByDateToDateSubTab = new Button();
        panel4 = new Panel();
        logoutTab = new Button();
        contentPanel = new Panel();
        menuTransition = new System.Windows.Forms.Timer(components);
        panel6 = new Panel();
        userTab = new Button();
        panel5 = new Panel();
        panel5.SuspendLayout();
        ((ISupportInitialize)exitBox).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        menuContainer.SuspendLayout();
        panel4.SuspendLayout();
        panel6.SuspendLayout();
        SuspendLayout();
        // 
        // panel5
        // 
        panel5.Controls.Add(exitBox);
        panel5.Dock = DockStyle.Top;
        panel5.Location = new Point(285, 0);
        panel5.Name = "panel5";
        panel5.Size = new Size(1073, 36);
        panel5.TabIndex = 0;
        // 
        // exitBox
        // 
        exitBox.Image = (Image)resources.GetObject("exitBox.Image");
        exitBox.Location = new Point(1036, 3);
        exitBox.Name = "exitBox";
        exitBox.Size = new Size(25, 24);
        exitBox.SizeMode = PictureBoxSizeMode.Zoom;
        exitBox.TabIndex = 14;
        exitBox.TabStop = false;
        exitBox.Click += exitBox_Click;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
        flowLayoutPanel1.Controls.Add(panel1);
        flowLayoutPanel1.Controls.Add(panel2);
        flowLayoutPanel1.Controls.Add(panel3);
        flowLayoutPanel1.Controls.Add(menuContainer);
        flowLayoutPanel1.Controls.Add(panel6);
        flowLayoutPanel1.Controls.Add(panel4);
        flowLayoutPanel1.Dock = DockStyle.Left;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(285, 815);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(companyTab);
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(285, 84);
        panel1.TabIndex = 2;
        // 
        // companyTab
        // 
        companyTab.BackColor = SystemColors.ActiveCaption;
        companyTab.FlatAppearance.BorderSize = 0;
        companyTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        companyTab.ForeColor = Color.White;
        companyTab.Image = (Image)resources.GetObject("companyTab.Image");
        companyTab.ImageAlign = ContentAlignment.MiddleLeft;
        companyTab.Location = new Point(3, 8);
        companyTab.Name = "companyTab";
        companyTab.Padding = new Padding(25, 0, 0, 0);
        companyTab.Size = new Size(273, 66);
        companyTab.TabIndex = 1;
        companyTab.Text = "Company";
        companyTab.UseVisualStyleBackColor = false;
        companyTab.Click += companyTab_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(modelTab);
        panel2.Location = new Point(3, 93);
        panel2.Name = "panel2";
        panel2.Size = new Size(285, 84);
        panel2.TabIndex = 3;
        // 
        // modelTab
        // 
        modelTab.BackColor = SystemColors.ActiveCaption;
        modelTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        modelTab.ForeColor = Color.White;
        modelTab.Image = (Image)resources.GetObject("modelTab.Image");
        modelTab.ImageAlign = ContentAlignment.MiddleLeft;
        modelTab.Location = new Point(3, 8);
        modelTab.Name = "modelTab";
        modelTab.Padding = new Padding(25, 0, 0, 0);
        modelTab.Size = new Size(273, 66);
        modelTab.TabIndex = 1;
        modelTab.Text = "Model";
        modelTab.UseVisualStyleBackColor = false;
        modelTab.Click += modelTab_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(mobileTab);
        panel3.Location = new Point(3, 183);
        panel3.Name = "panel3";
        panel3.Size = new Size(285, 84);
        panel3.TabIndex = 4;
        // 
        // mobileTab
        // 
        mobileTab.BackColor = SystemColors.ActiveCaption;
        mobileTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        mobileTab.ForeColor = Color.White;
        mobileTab.Image = (Image)resources.GetObject("mobileTab.Image");
        mobileTab.ImageAlign = ContentAlignment.MiddleLeft;
        mobileTab.Location = new Point(3, 8);
        mobileTab.Name = "mobileTab";
        mobileTab.Padding = new Padding(25, 0, 0, 0);
        mobileTab.Size = new Size(273, 66);
        mobileTab.TabIndex = 1;
        mobileTab.Text = "Mobile";
        mobileTab.UseVisualStyleBackColor = false;
        mobileTab.Click += mobileTab_Click;
        // 
        // menuContainer
        // 
        menuContainer.Controls.Add(salesTab);
        menuContainer.Controls.Add(byDateSubTab);
        menuContainer.Controls.Add(ByDateToDateSubTab);
        menuContainer.ForeColor = SystemColors.ActiveCaption;
        menuContainer.Location = new Point(3, 273);
        menuContainer.Name = "menuContainer";
        menuContainer.Size = new Size(285, 75);
        menuContainer.TabIndex = 4;
        // 
        // salesTab
        // 
        salesTab.BackColor = SystemColors.ActiveCaption;
        salesTab.FlatAppearance.BorderSize = 0;
        salesTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        salesTab.ForeColor = Color.White;
        salesTab.Image = (Image)resources.GetObject("salesTab.Image");
        salesTab.ImageAlign = ContentAlignment.MiddleLeft;
        salesTab.Location = new Point(3, 3);
        salesTab.Name = "salesTab";
        salesTab.Padding = new Padding(25, 0, 0, 0);
        salesTab.Size = new Size(273, 66);
        salesTab.TabIndex = 1;
        salesTab.Text = "Sales";
        salesTab.UseVisualStyleBackColor = false;
        salesTab.Click += salesTab_Click;
        // 
        // byDateSubTab
        // 
        byDateSubTab.BackColor = SystemColors.ActiveCaption;
        byDateSubTab.FlatAppearance.BorderSize = 0;
        byDateSubTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        byDateSubTab.ForeColor = Color.White;
        byDateSubTab.Image = (Image)resources.GetObject("byDateSubTab.Image");
        byDateSubTab.ImageAlign = ContentAlignment.MiddleLeft;
        byDateSubTab.Location = new Point(3, 75);
        byDateSubTab.Name = "byDateSubTab";
        byDateSubTab.Padding = new Padding(25, 0, 0, 0);
        byDateSubTab.Size = new Size(273, 66);
        byDateSubTab.TabIndex = 2;
        byDateSubTab.Text = "By Date";
        byDateSubTab.UseVisualStyleBackColor = false;
        byDateSubTab.Click += byDateSubTab_Click;
        // 
        // ByDateToDateSubTab
        // 
        ByDateToDateSubTab.BackColor = SystemColors.ActiveCaption;
        ByDateToDateSubTab.FlatAppearance.BorderSize = 0;
        ByDateToDateSubTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ByDateToDateSubTab.ForeColor = Color.White;
        ByDateToDateSubTab.Image = (Image)resources.GetObject("ByDateToDateSubTab.Image");
        ByDateToDateSubTab.ImageAlign = ContentAlignment.MiddleLeft;
        ByDateToDateSubTab.Location = new Point(3, 147);
        ByDateToDateSubTab.Name = "ByDateToDateSubTab";
        ByDateToDateSubTab.Padding = new Padding(25, 0, 0, 0);
        ByDateToDateSubTab.Size = new Size(273, 66);
        ByDateToDateSubTab.TabIndex = 3;
        ByDateToDateSubTab.Text = "By Date To Date";
        ByDateToDateSubTab.UseVisualStyleBackColor = false;
        ByDateToDateSubTab.Click += byDateToDateSubTab_Click;
        // 
        // panel4
        // 
        panel4.Controls.Add(logoutTab);
        panel4.Location = new Point(3, 444);
        panel4.Name = "panel4";
        panel4.Size = new Size(285, 84);
        panel4.TabIndex = 5;
        // 
        // logoutTab
        // 
        logoutTab.BackColor = SystemColors.ActiveCaption;
        logoutTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        logoutTab.ForeColor = Color.White;
        logoutTab.Image = (Image)resources.GetObject("logoutTab.Image");
        logoutTab.ImageAlign = ContentAlignment.MiddleLeft;
        logoutTab.Location = new Point(3, 8);
        logoutTab.Name = "logoutTab";
        logoutTab.Padding = new Padding(25, 0, 0, 0);
        logoutTab.Size = new Size(273, 66);
        logoutTab.TabIndex = 1;
        logoutTab.Text = "Logout";
        logoutTab.UseVisualStyleBackColor = false;
        // 
        // contentPanel
        // 
        contentPanel.Dock = DockStyle.Bottom;
        contentPanel.Location = new Point(285, 33);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(1073, 782);
        contentPanel.TabIndex = 1;
        contentPanel.Paint += contentPanel_Paint;
        // 
        // menuTransition
        // 
        menuTransition.Interval = 15;
        menuTransition.Tick += menuTransition_Tick;
        // 
        // panel6
        // 
        panel6.Controls.Add(userTab);
        panel6.Location = new Point(3, 354);
        panel6.Name = "panel6";
        panel6.Size = new Size(285, 84);
        panel6.TabIndex = 4;
        // 
        // userTab
        // 
        userTab.BackColor = SystemColors.ActiveCaption;
        userTab.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        userTab.ForeColor = Color.White;
        userTab.Image = (Image)resources.GetObject("userTab.Image");
        userTab.ImageAlign = ContentAlignment.MiddleLeft;
        userTab.Location = new Point(3, 8);
        userTab.Name = "userTab";
        userTab.Padding = new Padding(25, 0, 0, 0);
        userTab.Size = new Size(273, 66);
        userTab.TabIndex = 1;
        userTab.Text = "User";
        userTab.UseVisualStyleBackColor = false;
        userTab.Click += UsersTab_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1358, 815);
        Controls.Add(panel5);
        Controls.Add(contentPanel);
        Controls.Add(flowLayoutPanel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "x";
        Load += MainForm_Load;
        panel5.ResumeLayout(false);
        ((ISupportInitialize)exitBox).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        menuContainer.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Button companyTab;
    private Panel panel1;
    private Panel panel2;
    private Button modelTab;
    private Panel panel3;
    private Button mobileTab;
    private Panel panel4;
    private Button logoutTab;
    private Panel contentPanel;
    private FlowLayoutPanel menuContainer;
    private Button salesTab;
    private Button byDateSubTab;
    private Button ByDateToDateSubTab;
    private System.Windows.Forms.Timer menuTransition;
    private Panel panel5;
    private PictureBox exitBox;
    private Panel panel6;
    private Button userTab;
}