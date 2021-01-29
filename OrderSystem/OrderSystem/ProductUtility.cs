using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class ProductUtility
    {
        //新增菜單項目
        public static void MenuAdd(Product prod)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd= new SqlCommand("Insert Into Menu( ProductName, ProductType, Price) Values (@ProductName, @ProductType, @Price) ", cn);
            cmd.Parameters.AddWithValue("@ProductName", prod.ProductName);
            cmd.Parameters.AddWithValue("@ProductType", prod.ProductType);
            cmd.Parameters.AddWithValue("@Price", prod.price);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //修改菜單項目
        public static void MenuUpdate(Product prod)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("Update Menu Set ProductName=@ProductName, ProductType=@ProductType, Price=@Price Where ProductID=@ProductID", cn);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", prod.ProductName);
            cmd.Parameters.AddWithValue("@ProductType", prod.ProductType);
            cmd.Parameters.AddWithValue("@Price", prod.price);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //讀取所有菜單
        public static List<Product> GetAllMenu()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Menu", cnStr);

            DataTable dt = new DataTable();
            da.Fill(dt);
            var query = from row in dt.AsEnumerable()
                        select new Product()
                        {
                            ProductID = Convert.ToInt32(row["ProductID"]),
                            ProductName = row["ProductName"].ToString(),
                            ProductType = row["ProductType"].ToString(),
                            price=Convert.ToInt32(row["price"])
                        };

            
            return query.ToList();
        }
        public static void DeleteProduct(Product prod)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("Delete From Menu Where ProductID=@ProductID", cn);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static List<Product> SearchProduct(string keyword)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Menu Where ProductName LIKE '%'+@ProductName+'%'", cnStr);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", keyword);

            DataTable dt = new DataTable();
            da.Fill(dt);
            var query = from row in dt.AsEnumerable()
                        select new Product() {
                             ProductID=Convert.ToInt32(row["ProductID"]),
                               ProductName=row["ProductName"].ToString(),
                                ProductType=row["ProductType"].ToString(),
                                 price=Convert.ToDecimal(row["price"])
                        };

            return query.ToList();
        }
    }
}
