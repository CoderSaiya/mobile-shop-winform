namespace MobileShop.UI.Forms.Views
{
    partial class CompanyControl
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
            components = new System.ComponentModel.Container();
            //
            // Main layout
            //
            mainLayout = new TableLayoutPanel();
            panelTop = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();

            panelFilter = new Panel();
            lblFilter = new Label();
            txtFilter = new TextBox();
            btnSearch = new Button();

            dataGridView1 = new DataGridView();

            panelBottom = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));   // Top panel
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));   // Filter panel
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));   // DataGridView
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));   // Bottom panel
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new System.Drawing.Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Size = new System.Drawing.Size(800, 450);
            mainLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Fill;
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(btnRefresh);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(10, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(204, 28);
            lblTitle.Text = "Company Manager";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new System.Drawing.Point(700, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(80, 30);
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
            // 
            // panelFilter
            // 
            panelFilter.Dock = DockStyle.Fill;
            panelFilter.Controls.Add(lblFilter);
            panelFilter.Controls.Add(txtFilter);
            panelFilter.Controls.Add(btnSearch);
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new System.Drawing.Point(10, 12);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(97, 20);
            lblFilter.Text = "Filter Name:";
            // 
            // txtFilter
            // 
            txtFilter.Location = new System.Drawing.Point(110, 9);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(200, 27);
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(320, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(80, 30);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += new System.EventHandler(btnSearch_Click);
            // 
            // dataGridView1
            // 
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnClose);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(10, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(80, 30);
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(100, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(80, 30);
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += new System.EventHandler(btnEdit_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(190, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(80, 30);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(700, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(80, 30);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += new System.EventHandler(btnClose_Click);
            // 
            // CompanyControl
            // 
            Controls.Add(mainLayout);
            Name = "CompanyControl";
            Size = new System.Drawing.Size(800, 450);

            // Add panels to layout
            mainLayout.Controls.Add(panelTop, 0, 0);
            mainLayout.Controls.Add(panelFilter, 0, 1);
            mainLayout.Controls.Add(dataGridView1, 0, 2);
            mainLayout.Controls.Add(panelBottom, 0, 3);

            // Perform layout
            mainLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Panel panelTop;
        private Label lblTitle;
        private Button btnRefresh;

        private Panel panelFilter;
        private Label lblFilter;
        private TextBox txtFilter;
        private Button btnSearch;

        private DataGridView dataGridView1;

        private Panel panelBottom;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
    }
}