using Microsoft.Data.SqlClient;
using System.Configuration;

namespace MobileShop.UI.Forms.Helpers
{
    public class DbHelper
    {
        private static readonly string _connString =
            ConfigurationManager
                .ConnectionStrings["PhoneShopDB"]!
                .ConnectionString;

        public static SqlConnection GetConnection()
            => new SqlConnection(_connString);
    }
}
