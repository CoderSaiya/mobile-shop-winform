using Microsoft.Data.SqlClient;
using MobileShop.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.UI.Forms.Views
{
    public partial class ByDateToDateControl : UserControl
    {
        public ByDateToDateControl()
        {
            InitializeComponent();
        }

        private void BtnReportRange_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFromDate.Value.Date;
            DateTime to = dtpToDate.Value.Date;

            if (to < from)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = GetSalesByDateRange(from, to);
            dgvRangeReport.DataSource = dt;
        }

        private DataTable GetSalesByDateRange(DateTime from, DateTime to)
        {
            var dt = new DataTable();
            string sql = @"
                SELECT 
                    s.IMEINO,
                    m.ModelId,
                    mo.ModelNum,
                    s.PurchaseDate,
                    s.SalePrice,
                    c.Cust_Name
                FROM dbo.tbl_Sales AS s
                INNER JOIN dbo.tbl_Mobile AS m
                    ON s.IMEINO = m.IMEINO
                INNER JOIN dbo.tbl_Model AS mo
                    ON m.ModelId = mo.ModelId
                INNER JOIN dbo.tbl_Customer AS c
                    ON s.CustId = c.CustId
                WHERE CAST(s.PurchaseDate AS date) BETWEEN @From AND @To
                ORDER BY s.PurchaseDate;
            ";

            using var conn = DbHelper.GetConnection();
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@From", SqlDbType.Date).Value = from;
                cmd.Parameters.Add("@To", SqlDbType.Date).Value = to;
                da.Fill(dt);
            }

            return dt;
        }
    }
}
