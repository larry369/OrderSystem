using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class OrderCheck : Form
    {
        public OrderCheck()
        {
            InitializeComponent();
        }

        private void OrderCheck_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'storeDataSet3.OrdersList' 資料表。您可以視需要進行移動或移除。
            this.ordersListTableAdapter1.Fill(this.storeDataSet3.OrdersList);

        }

        private void Search_ord_btn_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Text).ToShortDateString());
            DateTime searchdate = Convert.ToDateTime(Convert.ToDateTime(dateTimePicker1.Text).ToShortDateString());
            dataGridView1.DataSource = OrderUtility.SearchByDate(searchdate);
            dataGridView1.Refresh();
            //MessageBox.Show(DateTime.Now.ToShortDateString());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value!=System.DBNull.Value)
            {
                int OrderID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                //List<Order> OrderDetails=OrderUtility.GetOrderDetailsByID(OrderID);
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                dataGridView2.DataSource= OrderUtility.GetOrderDetailsByID(OrderID, date);
                dataGridView2.Refresh();
            }
        }
    }
}
