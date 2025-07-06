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
            this.dtpSingleDate = new System.Windows.Forms.DateTimePicker();
            this.btnReportSingle = new System.Windows.Forms.Button();
            this.dgvSingleReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSingleDate
            // 
            this.dtpSingleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSingleDate.Location = new System.Drawing.Point(10, 10);
            this.dtpSingleDate.Name = "dtpSingleDate";
            this.dtpSingleDate.Size = new System.Drawing.Size(120, 27);
            this.dtpSingleDate.TabIndex = 0;
            // 
            // btnReportSingle
            // 
            this.btnReportSingle.Location = new System.Drawing.Point(140, 10);
            this.btnReportSingle.Name = "btnReportSingle";
            this.btnReportSingle.Size = new System.Drawing.Size(100, 27);
            this.btnReportSingle.TabIndex = 1;
            this.btnReportSingle.Text = "Báo cáo";
            this.btnReportSingle.UseVisualStyleBackColor = true;
            this.btnReportSingle.Click += new System.EventHandler(this.BtnReportSingle_Click);
            // 
            // dgvSingleReport
            // 
            this.dgvSingleReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                         | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSingleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingleReport.Location = new System.Drawing.Point(10, 50);
            this.dgvSingleReport.Name = "dgvSingleReport";
            this.dgvSingleReport.RowHeadersWidth = 51;
            this.dgvSingleReport.Size = new System.Drawing.Size(360, 240);
            this.dgvSingleReport.TabIndex = 2;
            // 
            // SingleDateControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtpSingleDate);
            this.Controls.Add(this.btnReportSingle);
            this.Controls.Add(this.dgvSingleReport);
            this.Name = "SingleDateControl";
            this.Size = new System.Drawing.Size(380, 300);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleReport)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpSingleDate;
        private Button btnReportSingle;
        private DataGridView dgvSingleReport;
    }
}
