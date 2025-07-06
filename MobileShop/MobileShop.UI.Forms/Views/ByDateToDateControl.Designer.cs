namespace MobileShop.UI.Forms.Views
{
    partial class ByDateToDateControl
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
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnReportRange = new System.Windows.Forms.Button();
            this.dgvRangeReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(10, 10);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(100, 27);
            this.dtpFromDate.TabIndex = 0;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(120, 10);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(100, 27);
            this.dtpToDate.TabIndex = 1;
            // 
            // btnReportRange
            // 
            this.btnReportRange.Location = new System.Drawing.Point(230, 10);
            this.btnReportRange.Name = "btnReportRange";
            this.btnReportRange.Size = new System.Drawing.Size(100, 27);
            this.btnReportRange.TabIndex = 2;
            this.btnReportRange.Text = "Báo cáo";
            this.btnReportRange.UseVisualStyleBackColor = true;
            this.btnReportRange.Click += new System.EventHandler(this.BtnReportRange_Click);
            // 
            // dgvRangeReport
            // 
            this.dgvRangeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                          | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRangeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangeReport.Location = new System.Drawing.Point(10, 50);
            this.dgvRangeReport.Name = "dgvRangeReport";
            this.dgvRangeReport.RowHeadersWidth = 51;
            this.dgvRangeReport.Size = new System.Drawing.Size(360, 240);
            this.dgvRangeReport.TabIndex = 3;
            // 
            // DateRangeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.btnReportRange);
            this.Controls.Add(this.dgvRangeReport);
            this.Name = "DateRangeControl";
            this.Size = new System.Drawing.Size(380, 300);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangeReport)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnReportRange;
        private DataGridView dgvRangeReport;
    }
}
