namespace OrderSystem
{
    partial class OrderCheck
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet3 = new OrderSystem.StoreDataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ordersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search_ord_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.storeDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersListTableAdapter1 = new OrderSystem.StoreDataSet3TableAdapters.OrdersListTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderShortdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderShortdateDataGridViewTextBoxColumn,
            this.orderTotalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(35, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 577);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ordersListBindingSource1
            // 
            this.ordersListBindingSource1.DataMember = "OrdersList";
            this.ordersListBindingSource1.DataSource = this.storeDataSet3;
            // 
            // storeDataSet3
            // 
            this.storeDataSet3.DataSetName = "StoreDataSet3";
            this.storeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(429, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 577);
            this.dataGridView2.TabIndex = 1;
            // 
            // ordersListBindingSource
            // 
            this.ordersListBindingSource.DataMember = "OrdersList";
            // 
            // Search_ord_btn
            // 
            this.Search_ord_btn.Location = new System.Drawing.Point(303, 49);
            this.Search_ord_btn.Name = "Search_ord_btn";
            this.Search_ord_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_ord_btn.TabIndex = 3;
            this.Search_ord_btn.Text = "查詢";
            this.Search_ord_btn.UseVisualStyleBackColor = true;
            this.Search_ord_btn.Click += new System.EventHandler(this.Search_ord_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ordersListTableAdapter1
            // 
            this.ordersListTableAdapter1.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "訂單編號";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderShortdateDataGridViewTextBoxColumn
            // 
            this.orderShortdateDataGridViewTextBoxColumn.DataPropertyName = "OrderShortdate";
            this.orderShortdateDataGridViewTextBoxColumn.HeaderText = "訂單日期";
            this.orderShortdateDataGridViewTextBoxColumn.Name = "orderShortdateDataGridViewTextBoxColumn";
            // 
            // orderTotalPriceDataGridViewTextBoxColumn
            // 
            this.orderTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderTotalPrice";
            this.orderTotalPriceDataGridViewTextBoxColumn.HeaderText = "訂單價格";
            this.orderTotalPriceDataGridViewTextBoxColumn.Name = "orderTotalPriceDataGridViewTextBoxColumn";
            // 
            // OrderCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 738);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Search_ord_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderCheck";
            this.Text = "OrderCheck";
            this.Load += new System.EventHandler(this.OrderCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ordersListBindingSource;
        private System.Windows.Forms.Button Search_ord_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource storeDataSet2BindingSource;
        private StoreDataSet3 storeDataSet3;
        private System.Windows.Forms.BindingSource ordersListBindingSource1;
        private StoreDataSet3TableAdapters.OrdersListTableAdapter ordersListTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderShortdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn;
    }
}