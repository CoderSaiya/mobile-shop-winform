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

            // Main layout
            this.mainLayout = new TableLayoutPanel();
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.btnRefresh = new Button();

            this.panelFilter = new Panel();
            this.lblFilter = new Label();
            this.txtFilter = new TextBox();
            this.btnSearch = new Button();

            this.dataGridView1 = new DataGridView();

            this.panelBottom = new Panel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnClose = new Button();

            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));   // Top panel
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));   // Filter panel
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));   // DataGridView
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));   // Bottom panel
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 0;

            // 
            // panelTop
            // 
            this.panelTop.Dock = DockStyle.Fill;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnRefresh);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 28);
            this.lblTitle.Text = "Company Manager";

            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(700, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // panelFilter
            // 
            this.panelFilter.Dock = DockStyle.Fill;
            this.panelFilter.Controls.Add(this.lblFilter);
            this.panelFilter.Controls.Add(this.txtFilter);
            this.panelFilter.Controls.Add(this.btnSearch);

            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(10, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(97, 20);
            this.lblFilter.Text = "Filter Name:";

            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(110, 9);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 27);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // panelBottom
            // 
            this.panelBottom.Dock = DockStyle.Fill;
            this.panelBottom.Controls.Add(this.btnAdd);
            this.panelBottom.Controls.Add(this.btnEdit);
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnClose);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClose
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(700, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // CompanyControl
            // 
            this.Controls.Add(this.mainLayout);
            this.Name = "CompanyControl";
            this.Size = new System.Drawing.Size(800, 450);

            // Add panels to layout
            this.mainLayout.Controls.Add(this.panelTop, 0, 0);
            this.mainLayout.Controls.Add(this.panelFilter, 0, 1);
            this.mainLayout.Controls.Add(this.dataGridView1, 0, 2);
            this.mainLayout.Controls.Add(this.panelBottom, 0, 3);

            // Perform layout
            this.mainLayout.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
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