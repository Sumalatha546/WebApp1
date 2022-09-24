using System.Data.SqlClient;
using WebApp1.Models;

namespace WebApp1.Services
{
    public class ProductService
    { 
        public static string db_source = "";
        public static string db_user = "";
        public static string db_password = "";
        public static string db_database = "";

        private SqlConnection GetConnection()
        {
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;  
            _builder.Password = db_password;  
            _builder.InitialCatalog= db_database;

            return new SqlConnection(_builder.ConnectionString);
           
           }

        public List<Product> GetProducts()
        {
            SqlConnection conn = GetConnection();
            List<Product> products = new List<Product>();
            string statement = "Select Productid from Products";






        }
    }
}
