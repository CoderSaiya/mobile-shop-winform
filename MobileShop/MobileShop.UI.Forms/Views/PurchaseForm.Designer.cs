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
            this.components = new System.ComponentModel.Container();
            this.Text = "Danh sách điện thoại";
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            //
            // txtSearchImei
            //
            txtSearchImei = new MaterialTextBox
            {
                Hint = "Nhập IMEI...",
                Location = new System.Drawing.Point(20, 80),
                Size = new System.Drawing.Size(200, 36)
            };
            Controls.Add(txtSearchImei);
            //
            // btnSearch
            //
            btnSearch = new MaterialButton
            {
                Text = "Tìm kiếm",
                Location = new System.Drawing.Point(240, 80),
                Size = new System.Drawing.Size(100, 36)
            };
            btnSearch.Click += BtnSearch_Click;
            Controls.Add(btnSearch);
            //
            // lblStatusFilter
            //
            lblStatusFilter = new MaterialLabel
            {
                Text = "Status:",
                Location = new System.Drawing.Point(360, 88),
                AutoSize = true
            };
            Controls.Add(lblStatusFilter);

            cbxStatusFilter = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(420, 84),
                Size = new System.Drawing.Size(120, 24)
            };
            cbxStatusFilter.Items.AddRange(new object[] { "All", "Available", "Sold" });
            cbxStatusFilter.SelectedIndex = 0;
            cbxStatusFilter.SelectedIndexChanged += (s, e) => LoadAllPhones();
            Controls.Add(cbxStatusFilter);
            //
            // flpPhones
            //
            flpPhones = new FlowLayoutPanel
            {
                Location = new System.Drawing.Point(20, 140),
                Size = new System.Drawing.Size(840, 400),
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            Controls.Add(flpPhones);
        }

        #endregion
        
        private MaterialTextBox txtSearchImei;
        private MaterialButton btnSearch;
        private MaterialLabel lblStatusFilter;
        private ComboBox cbxStatusFilter;
        private FlowLayoutPanel flpPhones;
    }
}