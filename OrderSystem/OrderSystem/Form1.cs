using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        string cnStr = OrderSystem.Properties.Settings.Default.StoreConnectionString;
        //訂單編號，利用傳址呼叫
        int CountCount = 1;
        public int OrderNumberAdd(ref int od)
        {
            return CountCount += 1;
        }
        int OrderTotalPrice = 0;
        public int OrderTotalPriceAdd(ref int op)
        {
            return OrderTotalPrice += op;
        }
        public int OrderTotalPriceZero(ref int opz)
        {
            return OrderTotalPrice = 0;
        }
        public string OrderCount(ref string count)
        {
            return ProductCount_lab.Text += count;
        }
        public string CheckOut(ref string checkout)
        {
            return cash_in_txt.Text += checkout;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'storeDataSet.Menu' 資料表。您可以視需要進行移動或移除。
            this.menuTableAdapter.Fill(this.storeDataSet.Menu);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial",15);//dataGridView1的內容字體大小與字形
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);//dataGridView1的標題字體大小與字形
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 20);
            //dataGridView1.DataSource = ProductUtility.GetAllMenu();
            int OrderCount;//OrderNumber訂單編號、OrderCount訂單數量
            int OrderNumber;
            string OrderProduct;//餐點名稱
            OrderProduct = "";
            OrderNumber = 0;
            OrderCount = 0;
            //OrderID_lab.Text = OrderNumber.ToString();
            DateTime Today = DateTime.Now;//紀錄今天日期//目前沒用處
            OrderID_lab.Text = CountCount.ToString();

        } 
        /// <summary>
        /// 前往新增、刪除、修改、查詢產品頁面
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            newProduct np = new newProduct();
            np.ShowDialog();
        }

        /// <summary>
        /// 重載
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductUtility.GetAllMenu();
            dataGridView1.Refresh();
        }
        /// <summary>
        /// dataGridView1選取事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dataGridView1.Rows[e.RowIndex]);//該列的索引值
            //Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);//該列第一欄的值
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value!=System.DBNull.Value)
            {
                int ProductID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                SqlConnection cn = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand("SELECT ProductName, Price FROM Menu WHERE ProductID=@ProductID",cn);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductName_lab.Text = dr[0].ToString();

                    ProductPrice_lab.Text = Convert.ToDecimal(dr[1]).ToString();
                }
            }
        }

        private void ProductConfirm_btn_Click(object sender, EventArgs e)
        {
            //int datecheck = OrderUtility.getDate();
            //if (datecheck != null)
            //{

            //}
            if (ProductName_lab.Text=="無"||ProductName_lab.Text=="無"|| ProductCount_lab.Text==""||ProductCount_lab.Text==0.ToString())
            {
                MessageBox.Show("輸入錯誤");
            }
            else
            {
                Order ord = new Order() {
                    OrderID = Convert.ToInt32(OrderID_lab.Text),
                    Ordershortdate=Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Orderdate = Convert.ToDateTime(DateTime.Now.ToString("yyyy - MM - dd")),
                    OrderProductName = ProductName_lab.Text,
                    //Orderdate = Convert.ToDateTime(DateTime.Now),
                    OrderPrice = Convert.ToInt32(ProductPrice_lab.Text),
                    OrderCount=Convert.ToInt32(ProductCount_lab.Text),
                    OrderTotalPrice=Convert.ToInt32(ProductCount_lab.Text)*Convert.ToInt32(ProductPrice_lab.Text)
                };
                OrderUtility.OrderAdd(ord);
                //Console.WriteLine(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
                dataGridView2.DataSource = OrderUtility.GetAllOrder(Convert.ToInt32(OrderID_lab.Text));
                dataGridView2.Refresh();
                //dataGridView2.Columns[1].Visible = false;
                //int op = Convert.ToInt32(ProductCount_lab.Text) * Convert.ToInt32(ProductPrice_lab.Text);
                //OrderTotalPriceAdd(ref op);
                //TotalPrice_txt.Text = OrderTotalPrice.ToString();
                int ordtotalprice = 0;
                List<Order> ordList = OrderUtility.GetOrderPriceByOrderID(Convert.ToInt32(OrderID_lab.Text));
                foreach (Order item in ordList)
                {
                    ordtotalprice += item.OrderTotalPrice;
                }
                TotalPrice_txt.Text = ordtotalprice.ToString();


            }
            ProductCount_lab.Text = "";
        }
        /// <summary>
        /// dataGridView2.點選要刪除的訂單項目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != System.DBNull.Value)
            {
                int OrderID = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                string OrderProduct = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                MessageBox.Show(OrderProduct);
                label1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();//暫時存OrderID
                label2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();//暫時存訂單時間
                label3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();//暫時存產品名稱
                label4.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();//訂單單項目總價
                //SqlConnection cn = new SqlConnection(cnStr);
                //SqlCommand cmd = new SqlCommand()
            }
        }
        private void Orderconfirm_btn_Click(object sender, EventArgs e)
        {
            if (give_change_txt.Text=="")
            {
                MessageBox.Show("是否尚未收取現金");
            }
            else
            {
                OrderList ordList = new OrderList()
                {
                    OrderID = Convert.ToInt32(OrderID_lab.Text),
                    Ordershortdate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Orderdate = DateTime.Now,
                    OrderTotalPrice = Convert.ToInt32(TotalPrice_txt.Text)
                };
                OrderUtility.OrderListAdd(ordList);
                int OrderAdd=1;//訂單編號+1
                int OrderAddOne;
                OrderAddOne = OrderNumberAdd(ref OrderAdd);
                MessageBox.Show(OrderAddOne.ToString());
                OrderID_lab.Text = CountCount.ToString();
                //int opz = 0;
                //OrderTotalPriceZero(ref opz);
                //TotalPrice_txt.Text = OrderTotalPrice.ToString();
                dataGridView2.DataSource = null;//清空


                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                ProductName_lab.Text = "";
                ProductPrice_lab.Text = "";
                cash_in_txt.Text = "";
                give_change_txt.Text = "";
                TotalPrice_txt.Text = "";
                //另存一份訂購清單
            }
        }

        private void Order_delete_btn_Click(object sender, EventArgs e)
        {
            if (label1.Text=="")
            {
                MessageBox.Show("尚未選取要刪除的項目");
            }
            else
            {
                Order ord = new Order() {
                    OrderID = Convert.ToInt32(label1.Text),
                    Orderdate = Convert.ToDateTime(label2.Text),
                    OrderProductName = label3.Text,
                    OrderTotalPrice=Convert.ToInt32(label4.Text)
                };
                OrderUtility.DeleteOrder(ord);
                MessageBox.Show("刪除成功");
                int ordtotalprice = 0;
                List<Order> ordList = OrderUtility.GetOrderPriceByOrderID(Convert.ToInt32(OrderID_lab.Text));
                foreach (Order item in ordList)
                {
                    ordtotalprice += item.OrderTotalPrice;
                }
                dataGridView2.DataSource = OrderUtility.GetAllOrder(Convert.ToInt32(OrderID_lab.Text));
                dataGridView2.Refresh();
                TotalPrice_txt.Text = ordtotalprice.ToString();
            }
        }

        private void number1_Click(object sender, EventArgs e)
        {
            string number1 = "1";
            OrderCount(ref number1);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            string number2 = "2";
            OrderCount(ref number2);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            string number3 = "3";
            OrderCount(ref number3);
        }

        private void number0_Click(object sender, EventArgs e)
        {
            string number0 = "0";
            OrderCount(ref number0);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            string number4 = "4";
            OrderCount(ref number4);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            string number5 = "5";
            OrderCount(ref number5);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            string number6 = "6";
            OrderCount(ref number6);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            string number7 = "7";
            OrderCount(ref number7);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            string number8 = "8";
            OrderCount(ref number8);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            string number9 = "9";
            OrderCount(ref number9);
        }

        private void ProductCancel_btn_Click(object sender, EventArgs e)
        {
            ProductCount_lab.Text = "";
        }

        private void co_number0_Click(object sender, EventArgs e)
        {
            string co_number0 = "0";
            CheckOut(ref co_number0);
        }

        private void co_number1_Click(object sender, EventArgs e)
        {
            string co_number1 = "1";
            CheckOut(ref co_number1);
        }

        private void co_number2_Click(object sender, EventArgs e)
        {
            string co_number2 = "2";
            CheckOut(ref co_number2);
        }

        private void co_number3_Click(object sender, EventArgs e)
        {
            string co_number3 = "3";
            CheckOut(ref co_number3);
        }

        private void co_number4_Click(object sender, EventArgs e)
        {
            string co_number4 = "4";
            CheckOut(ref co_number4);
        }

        private void co_number5_Click(object sender, EventArgs e)
        {
            string co_number5 = "5";
            CheckOut(ref co_number5);
        }

        private void co_number6_Click(object sender, EventArgs e)
        {
            string co_number6 = "6";
            CheckOut(ref co_number6);
        }

        private void co_number7_Click(object sender, EventArgs e)
        {
            string co_number7 = "7";
            CheckOut(ref co_number7);
        }

        private void co_number8_Click(object sender, EventArgs e)
        {
            string co_number8 = "8";
            CheckOut(ref co_number8);
        }

        private void co_number9_Click(object sender, EventArgs e)
        {
            string co_number9 = "9";
            CheckOut(ref co_number9);
        }

        private void co_number_delete_Click(object sender, EventArgs e)
        {
            cash_in_txt.Text = "";
        }

        private void co_cashin_confirm_Click(object sender, EventArgs e)
        {
            if (cash_in_txt.Text==""||cash_in_txt.Text=="0"||Convert.ToInt32(cash_in_txt.Text)< Convert.ToInt32(TotalPrice_txt.Text)||TotalPrice_txt.Text=="0")
            {
                MessageBox.Show("輸入錯誤或尚未收取現金");
            }
            else
            {
                give_change_txt.Text=Convert.ToString(Convert.ToInt32(cash_in_txt.Text) - Convert.ToInt32(TotalPrice_txt.Text));
            }
        }

        private void order_check_btn_Click(object sender, EventArgs e)
        {
            OrderCheck oc = new OrderCheck();
            oc.ShowDialog();
        }

    }
}
