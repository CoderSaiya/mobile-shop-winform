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
            this.txtSearchImei = new MaterialTextBox();
            this.btnSearch = new MaterialButton();
            this.dgvStock = new DataGridView();
            this.lblStock = new MaterialLabel();
            this.btnBuy = new MaterialButton();
            // 
            // txtSearchImei
            // 
            this.txtSearchImei.Hint = "Search IMEI...";
            this.txtSearchImei.Size = new System.Drawing.Size(300, 48);
            this.txtSearchImei.Location = new System.Drawing.Point(24, 80);
            // 
            // btnSearch
            // 
            this.btnSearch.Text = "Search";
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(340, 80);
            this.btnSearch.Click += BtnSearch_Click;
            // 
            // dgvStock
            // 
            this.dgvStock.Location = new System.Drawing.Point(24, 140);
            this.dgvStock.Size = new System.Drawing.Size(740, 350);
            this.dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.SelectionChanged += (s, e) => btnBuy.Enabled = dgvStock.SelectedRows.Count > 0;
            // 
            // lblStock
            // 
            this.lblStock.Text = "Stock: 0";
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(24, 510);
            // 
            // btnBuy
            // 
            this.btnBuy.Text = "Buy Selected";
            this.btnBuy.AutoSize = true;
            this.btnBuy.Location = new System.Drawing.Point(660, 504);
            this.btnBuy.Enabled = false;
            this.btnBuy.Click += BtnBuy_Click;
            // 
            // PurchaseForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtSearchImei);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnBuy);
            this.Text = "Purchase Phone";
        }

        #endregion

        private MaterialTextBox txtSearchImei;
        private MaterialButton btnSearch;
        private DataGridView dgvStock;
        private MaterialLabel lblStock;
        private MaterialButton btnBuy;
    }
}