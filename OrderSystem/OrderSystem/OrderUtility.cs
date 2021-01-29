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
    class OrderUtility
    {
        //public static int getDate()
        //{
        //    DateTime Today = Convert.ToDateTime(DateTime.Now.ToString());//讀取今天日期
        //    string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
        //    SqlDataAdapter da = new SqlDataAdapter("Select * From Order Where OrderDate=@OrderDate", cnStr);
        //    da.SelectCommand.Parameters.AddWithValue("@OrderDate", Today.ToString());

 
        //    DataTable dt = new DataTable();
      
        //    da.Fill(dt);

        //    if (dt.Rows.Count == 0) //找不到
        //    {
        //        return Convert.ToInt32(null);
        //    }
        //    else
        //    {
        //        return 1;
        //    }



        //}
        /// <summary>
        /// 訂單列表結單
        /// </summary>
        /// <param name="ordList"></param>
        public static void OrderListAdd(OrderList ordList)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("Insert Into OrdersList(OrderID, OrderShortdate, Orderdate, OrderTotalPrice) Values(@OrderID, @OrderShortdate, @Orderdate, @OrderTotalPrice)", cn);
            cmd.Parameters.AddWithValue("@OrderID", ordList.OrderID);
            cmd.Parameters.AddWithValue("@OrderShortdate", ordList.Ordershortdate);
            cmd.Parameters.AddWithValue("@Orderdate", ordList.Orderdate);
            cmd.Parameters.AddWithValue("@OrderTotalPrice", ordList.OrderTotalPrice);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        /// <summary>
        /// 訂單詳細資訊
        /// </summary>
        /// <param name="ord"></param>
        public static void OrderAdd(Order ord)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd= new SqlCommand("Insert Into Orders  ( OrderID, Ordershortdate, Orderdate, OrderProductName, OrderPrice, OrderCount, OrderTotalPrice) Values (@OrderID, @Ordershortdate, @Orderdate, @OrderProductName, @OrderPrice, @OrderCount, @OrderTotalPrice) ", cn);
            cmd.Parameters.AddWithValue("@OrderID", ord.OrderID);
            cmd.Parameters.AddWithValue("@Ordershortdate", ord.Ordershortdate);
            cmd.Parameters.AddWithValue("@Orderdate", ord.Orderdate);
            cmd.Parameters.AddWithValue("@OrderProductName", ord.OrderProductName);
            cmd.Parameters.AddWithValue("@OrderPrice", ord.OrderPrice);
            cmd.Parameters.AddWithValue("@OrderCount", ord.OrderCount);
            cmd.Parameters.AddWithValue("@OrderTotalPrice", ord.OrderTotalPrice);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        /// <summary>
        /// dataGridView2顯示訂單資訊
        /// </summary>
        /// <param name="OrdNumber"></param>
        /// <returns></returns>
        public static List<Order> GetAllOrder(int OrdNumber)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select OrderID, Orderdate, OrderPrice, OrderProductName, OrderCount, OrderTotalPrice From Orders Where OrderID=@OrderNumber AND Orderdate=@Orderdate", cnStr);
            DateTime todaydate = Convert.ToDateTime(DateTime.Now.ToString("yyyy - MM - dd"));
            da.SelectCommand.Parameters.AddWithValue("@OrderNumber", OrdNumber);
            da.SelectCommand.Parameters.AddWithValue("@Orderdate", todaydate);

            DataTable dt = new DataTable();
            da.Fill(dt);
            var query = from row in dt.AsEnumerable()
                        select new Order()
                        {
                            OrderID=Convert.ToInt32(row["OrderID"]),
                            Orderdate=Convert.ToDateTime(row["Orderdate"]),
                            OrderPrice=Convert.ToInt32(row["OrderPrice"]),
                             OrderProductName=row["OrderProductName"].ToString(),
                              OrderCount=Convert.ToInt32(row["OrderCount"]),
                               OrderTotalPrice=Convert.ToInt32(row["OrderTotalPrice"])
                        };

            return query.ToList();
        }
        /// <summary>
        /// 計算訂單總價
        /// </summary>
        /// <param name="OrdNumber"></param>
        /// <returns></returns>
        public static List<Order>GetOrderPriceByOrderID(int OrdNumber)
        {
            DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Orders Where OrderID=@OrderNumber and Orderdate=@Orderdate ", cnStr);
            da.SelectCommand.Parameters.AddWithValue("@OrderNumber", OrdNumber);
            da.SelectCommand.Parameters.AddWithValue("@Orderdate", today);
            DataTable dt = new DataTable();
            da.Fill(dt);
            var query = from row in dt.AsEnumerable()
                        select new Order()
                        {
                            OrderID = Convert.ToInt32(row["OrderID"]),
                            Orderdate = Convert.ToDateTime(row["Orderdate"]),
                            OrderPrice = Convert.ToInt32(row["OrderPrice"]),
                            OrderProductName = row["OrderProductName"].ToString(),
                            OrderCount = Convert.ToInt32(row["OrderCount"]),
                            OrderTotalPrice = Convert.ToInt32(row["OrderTotalPrice"])
                        };

            return query.ToList();

        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        /// <param name="ord"></param>
        public static void DeleteOrder(Order ord)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("Delete From Orders Where OrderID=@OrderID AND Orderdate=@Orderdate AND OrderProductName=@OrderProductName AND OrderTotalPrice=@OrderTotalPrice", cn);
            cmd.Parameters.AddWithValue("@OrderID", ord.OrderID);
            cmd.Parameters.AddWithValue("@Orderdate", ord.Orderdate);
            cmd.Parameters.AddWithValue("@OrderProductName", ord.OrderProductName);
            cmd.Parameters.AddWithValue("@OrderTotalPrice", ord.OrderTotalPrice);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //以下ordercheck頁面使用的
        public static List<OrderList> SearchByDate(DateTime sdt)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select *  From OrdersList Where Ordershortdate=@Ordershortdate", cnStr);
            da.SelectCommand.Parameters.AddWithValue("@Ordershortdate", sdt);

            DataTable dt = new DataTable();
            da.Fill(dt);

            var query = from row in dt.AsEnumerable()
                        select new OrderList() {
                             OrderID=Convert.ToInt32(row["OrderID"]),
                             Ordershortdate = Convert.ToDateTime(row["Ordershortdate"]),
                             OrderTotalPrice=Convert.ToInt32(row["OrderTotalPrice"])
                        };
            return query.ToList();
 
        }
        /// <summary>
        /// prepare to change
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static List<Order> GetOrderDetailsByID(int OrderID, DateTime date)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["storeconnectionstring1"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Orders Where OrderID=@OrderID And Ordershortdate=@Ordershortdate", cnStr);
            da.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);
            da.SelectCommand.Parameters.AddWithValue("@Ordershortdate", date);
            DataTable dt = new DataTable();
            da.Fill(dt);

            var query = from row in dt.AsEnumerable()
                        select new Order() {
                             OrderID=(int)row["OrderID"],
                            Ordershortdate = Convert.ToDateTime(row["Ordershortdate"]),
                             OrderProductName=row["OrderProductName"].ToString(),
                             OrderPrice=(int)row["OrderPrice"],
                             OrderCount=(int)row["OrderCount"],
                             OrderTotalPrice=(int)row["OrderTotalPrice"]
                        };
            return query.ToList();
        }


    }
}
