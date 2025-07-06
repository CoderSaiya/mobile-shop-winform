namespace MobileShop.UI.Forms.Views
{
    partial class ByDateControl
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
            dtpSingleDate = new System.Windows.Forms.DateTimePicker();
            btnReportSingle = new System.Windows.Forms.Button();
            dgvSingleReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvSingleReport)).BeginInit();
            SuspendLayout();
            // 
            // dtpSingleDate
            // 
            dtpSingleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpSingleDate.Location = new System.Drawing.Point(10, 10);
            dtpSingleDate.Name = "dtpSingleDate";
            dtpSingleDate.Size = new System.Drawing.Size(120, 27);
            dtpSingleDate.TabIndex = 0;
            // 
            // btnReportSingle
            // 
            btnReportSingle.Location = new System.Drawing.Point(140, 10);
            btnReportSingle.Name = "btnReportSingle";
            btnReportSingle.Size = new System.Drawing.Size(100, 27);
            btnReportSingle.TabIndex = 1;
            btnReportSingle.Text = "Báo cáo";
            btnReportSingle.UseVisualStyleBackColor = true;
            btnReportSingle.Click += new System.EventHandler(BtnReportSingle_Click);
            // 
            // dgvSingleReport
            // 
            dgvSingleReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                         | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            dgvSingleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSingleReport.Location = new System.Drawing.Point(10, 50);
            dgvSingleReport.Name = "dgvSingleReport";
            dgvSingleReport.RowHeadersWidth = 51;
            dgvSingleReport.Size = new System.Drawing.Size(360, 240);
            dgvSingleReport.TabIndex = 2;
            // 
            // SingleDateControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(dtpSingleDate);
            Controls.Add(btnReportSingle);
            Controls.Add(dgvSingleReport);
            Name = "SingleDateControl";
            Size = new System.Drawing.Size(380, 300);
            ((System.ComponentModel.ISupportInitialize)(dgvSingleReport)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpSingleDate;
        private Button btnReportSingle;
        private DataGridView dgvSingleReport;
    }
}
