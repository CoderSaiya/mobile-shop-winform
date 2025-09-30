using System.ComponentModel;

namespace MobileShop.UI.Forms.Views;

partial class MemberForm
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
        this.components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            lblTitle = new Label();
            lblMember1 = new Label();
            lblMember2 = new Label();
            lblMember3 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Padding = new Padding(10);
            // 
            // lblTitle
            // 
            lblTitle.Text = "Giới thiệu thành viên";
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMember1
            // 
            lblMember1.Text = "Ngô Nhật Cường – 2251120201";
            lblMember1.Dock = DockStyle.Fill;
            lblMember1.Font = new Font("Segoe UI", 10F);
            lblMember1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMember2
            // 
            lblMember2.Text = "Phạm Huỳnh Thiên Huy – 22H1120106";
            lblMember2.Dock = DockStyle.Fill;
            lblMember2.Font = new Font("Segoe UI", 10F);
            lblMember2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMember3
            // 
            lblMember3.Text = "Nguyễn Thái Bình – 22H1120095";
            lblMember3.Dock = DockStyle.Fill;
            lblMember3.Font = new Font("Segoe UI", 10F);
            lblMember3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormIntroduction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 180);
            Controls.Add(this.tableLayoutPanel);
            // Add controls to table
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Controls.Add(lblMember1, 0, 1);
            tableLayoutPanel.Controls.Add(lblMember2, 0, 2);
            tableLayoutPanel.Controls.Add(lblMember3, 0, 3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormIntroduction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giới thiệu nhóm";
            ResumeLayout(false);
    }

    #endregion
    
    private TableLayoutPanel tableLayoutPanel;
    private Label lblTitle;
    private Label lblMember1;
    private Label lblMember2;
    private Label lblMember3;
}