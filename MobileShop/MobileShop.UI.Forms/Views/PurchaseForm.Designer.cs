using MaterialSkin.Controls;

namespace MobileShop.UI.Forms.Views
{
    partial class PurchaseForm
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
            txtSearchImei = new MaterialTextBox();
            btnSearch = new MaterialButton();
            btnLogout = new MaterialButton();
            dgvStock = new DataGridView();
            lblStock = new MaterialLabel();
            btnBuy = new MaterialButton();
            // 
            // txtSearchImei
            // 
            txtSearchImei.Hint = "Search IMEI...";
            txtSearchImei.Size = new System.Drawing.Size(300, 48);
            txtSearchImei.Location = new System.Drawing.Point(24, 80);
            // 
            // btnSearch
            // 
            btnSearch.Text = "Search";
            btnSearch.AutoSize = true;
            btnSearch.Location = new System.Drawing.Point(340, 80);
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.Text = "Logout";
            btnLogout.AutoSize = true;
            btnLogout.Location = new System.Drawing.Point(440, 80);
            btnLogout.Click += BtnLogout_Click;
            // 
            // dgvStock
            // 
            dgvStock.Location = new System.Drawing.Point(24, 140);
            dgvStock.Size = new System.Drawing.Size(740, 350);
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.SelectionChanged += (s, e) => btnBuy.Enabled = dgvStock.SelectedRows.Count > 0;
            // 
            // lblStock
            // 
            lblStock.Text = "Stock: 0";
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(24, 510);
            // 
            // btnBuy
            // 
            btnBuy.Text = "Buy Selected";
            btnBuy.AutoSize = true;
            btnBuy.Location = new System.Drawing.Point(660, 504);
            btnBuy.Enabled = false;
            btnBuy.Click += BtnBuy_Click;
            // 
            // PurchaseForm
            // 
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(txtSearchImei);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(dgvStock);
            Controls.Add(lblStock);
            Controls.Add(btnBuy);
            Text = "Purchase Phone";
        }

        #endregion

        private MaterialTextBox txtSearchImei;
        private MaterialButton btnSearch;
        private MaterialButton btnLogout;
        private DataGridView dgvStock;
        private MaterialLabel lblStock;
        private MaterialButton btnBuy;
    }
}