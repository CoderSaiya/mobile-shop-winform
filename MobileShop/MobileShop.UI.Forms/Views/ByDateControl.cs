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
using static Jenga.Theme;

namespace MobileShop.UI.Forms.Views
{
    public partial class ByDateControl : UserControl
    {
        public ByDateControl()
        {
            InitializeComponent();
        }

        private void BtnReportSingle_Click(object sender, EventArgs e)
        {
            DateTime date = dtpSingleDate.Value.Date;
            DataTable dt = GetSalesByDate(date);
            dgvSingleReport.DataSource = dt;
        }

        private DataTable GetSalesByDate(DateTime date)
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
                WHERE CAST(s.PurchaseDate AS date) = @Date
                ORDER BY s.PurchaseDate;
            ";

            using var conn = DbHelper.GetConnection();
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = date;
                da.Fill(dt);
            }

            return dt;
        }
    }
}