namespace MobileShop.UI.Forms.Views
{
    partial class MobileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            mainLayout = new TableLayoutPanel();
            panelTop = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            panelFilter = new Panel();
            lblFilter = new Label();
            txtFilter = new TextBox();
            btnSearch = new Button();
            dataGridView = new DataGridView();
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
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.Dock = DockStyle.Fill;
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
            lblTitle.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(10, 13);
            lblTitle.Text = "Mobile Manager";
            //
            // btnRefresh
            //
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(700, 10);
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
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
            lblFilter.Location = new Point(10, 12);
            lblFilter.Text = "Filter IMEI:";
            //
            // txtFilter
            //
            txtFilter.Location = new Point(110, 9);
            txtFilter.Size = new Size(200, 27);
            //
            // btnSearch
            //
            btnSearch.Location = new Point(320, 6);
            btnSearch.Size = new Size(80, 30);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            //
            // dataGridView
            //
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            btnAdd.Location = new Point(10, 15);
            btnAdd.Size = new Size(80, 30);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            //
            // btnEdit
            //
            btnEdit.Location = new Point(100, 15);
            btnEdit.Size = new Size(80, 30);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(190, 15);
            btnDelete.Size = new Size(80, 30);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            //
            // btnClose
            //
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(700, 15);
            btnClose.Size = new Size(80, 30);
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            //
            // Compose
            //
            Controls.Add(mainLayout);
            mainLayout.Controls.Add(panelTop, 0, 0);
            mainLayout.Controls.Add(panelFilter, 0, 1);
            mainLayout.Controls.Add(dataGridView, 0, 2);
            mainLayout.Controls.Add(panelBottom, 0, 3);
            Name = "MobileControl";
            Size = new Size(800, 450);
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
        private DataGridView dataGridView;
        private Panel panelBottom;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
    }
}
