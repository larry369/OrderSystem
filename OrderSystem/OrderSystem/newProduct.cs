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
    public partial class newProduct : Form
    {
        string cnStr = OrderSystem.Properties.Settings.Default.StoreConnectionString;
        public newProduct()
        {
            InitializeComponent();
        }
        private void newProduct_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'storeDataSet.Menu' 資料表。您可以視需要進行移動或移除。
            this.menuTableAdapter.Fill(this.storeDataSet.Menu);

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Product menuin = new Product()
        //    {
        //        ProductName = textBox1.Text,
        //        ProductType = textBox2.Text,
        //        price = Convert.ToDecimal(textBox3.Text)
        //    };

        //    ProductUtility.MenuAdd(menuin);
        //    MessageBox.Show("新增成功");
        //    dataGridView1.DataSource = ProductUtility.GetAllMenu();
        //    dataGridView1.Refresh();
        //}
        /// <summary>
        /// 新增產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("尚未輸入新增的項目");
            }
            else
            {
                Product menuin = new Product()
                {
                    ProductName = textBox1.Text,
                    ProductType = textBox2.Text,
                    price = Convert.ToDecimal(textBox3.Text)
                };

                ProductUtility.MenuAdd(menuin);
                MessageBox.Show("新增成功");
                dataGridView1.DataSource = ProductUtility.GetAllMenu();
                dataGridView1.Refresh();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != System.DBNull.Value)
            {
                int ProductID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                SqlConnection cn = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, ProductType, Price FROM Menu WHERE ProductID=@ProductID", cn);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr[1].ToString();
                    textBox2.Text = dr[2].ToString();
                    textBox3.Text = Convert.ToDecimal(dr[3]).ToString();
                    Hidden_ProductID_lab.Text = dr[0].ToString();
                    //MessageBox.Show(Hidden_ProductID_lab.Text);
                }
            }
        }
        /// <summary>
        /// 修改產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProduct_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("尚未選擇修改的品項或內容不可為空白");
            }
            else
            {
                Product prod = new Product()
                {
                    ProductID = Convert.ToInt32(Hidden_ProductID_lab.Text),
                    ProductName = textBox1.Text,
                    ProductType = textBox2.Text,
                    price = Convert.ToDecimal(textBox3.Text)
                };
                ProductUtility.MenuUpdate(prod);
                dataGridView1.DataSource = ProductUtility.GetAllMenu();
                dataGridView1.Refresh();
                MessageBox.Show("修改成功");
            }
        }
        /// <summary>
        /// 刪除產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("尚未選擇刪除的品項或內容不可為空白");
            }
            else
            {
                Product prod = new Product()
                {
                    ProductID = Convert.ToInt32(Hidden_ProductID_lab.Text),
                    ProductName = textBox1.Text,
                    ProductType = textBox2.Text,
                    price = Convert.ToDecimal(textBox3.Text)
                };
                ProductUtility.DeleteProduct(prod);
                dataGridView1.DataSource = ProductUtility.GetAllMenu();
                dataGridView1.Refresh();
                MessageBox.Show("刪除成功");
            }
        }

        private void search_product_btn_Click(object sender, EventArgs e)
        {
            if (Searchbar.Text=="")
            {
                MessageBox.Show("尚未輸入查詢品項");
            }
            else
            {
                string searchkeyword = Searchbar.Text;
                dataGridView1.DataSource = ProductUtility.SearchProduct(searchkeyword);
                dataGridView1.Refresh();
            }

        }
    }
}
