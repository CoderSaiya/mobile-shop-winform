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
            dtpFromDate = new System.Windows.Forms.DateTimePicker();
            dtpToDate = new System.Windows.Forms.DateTimePicker();
            btnReportRange = new System.Windows.Forms.Button();
            dgvRangeReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvRangeReport)).BeginInit();
            SuspendLayout();
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFromDate.Location = new System.Drawing.Point(10, 10);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new System.Drawing.Size(100, 27);
            dtpFromDate.TabIndex = 0;
            // 
            // dtpToDate
            // 
            dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpToDate.Location = new System.Drawing.Point(120, 10);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new System.Drawing.Size(100, 27);
            dtpToDate.TabIndex = 1;
            // 
            // btnReportRange
            // 
            btnReportRange.Location = new System.Drawing.Point(230, 10);
            btnReportRange.Name = "btnReportRange";
            btnReportRange.Size = new System.Drawing.Size(100, 27);
            btnReportRange.TabIndex = 2;
            btnReportRange.Text = "Báo cáo";
            btnReportRange.UseVisualStyleBackColor = true;
            btnReportRange.Click += new System.EventHandler(BtnReportRange_Click);
            // 
            // dgvRangeReport
            // 
            dgvRangeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                          | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
            dgvRangeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRangeReport.Location = new System.Drawing.Point(10, 50);
            dgvRangeReport.Name = "dgvRangeReport";
            dgvRangeReport.RowHeadersWidth = 51;
            dgvRangeReport.Size = new System.Drawing.Size(360, 240);
            dgvRangeReport.TabIndex = 3;
            // 
            // DateRangeControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(dtpFromDate);
            Controls.Add(dtpToDate);
            Controls.Add(btnReportRange);
            Controls.Add(dgvRangeReport);
            Name = "DateRangeControl";
            Size = new System.Drawing.Size(380, 300);
            ((System.ComponentModel.ISupportInitialize)(dgvRangeReport)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnReportRange;
        private DataGridView dgvRangeReport;
    }
}
