namespace OrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new OrderSystem.StoreDataSet();
            this.OrderNumber = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPrice_txt = new System.Windows.Forms.Label();
            this.ProductCount_lab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.ProductCancel_btn = new System.Windows.Forms.Button();
            this.ProductName_lab = new System.Windows.Forms.Label();
            this.ProductPrice_lab = new System.Windows.Forms.Label();
            this.Orderconfirm_btn = new System.Windows.Forms.Button();
            this.ProductConfirm_btn = new System.Windows.Forms.Button();
            this.menuTableAdapter = new OrderSystem.StoreDataSetTableAdapters.MenuTableAdapter();
            this.button13 = new System.Windows.Forms.Button();
            this.OrderID_lab = new System.Windows.Forms.Label();
            this.Order_delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cash_in_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.co_number0 = new System.Windows.Forms.Button();
            this.co_number3 = new System.Windows.Forms.Button();
            this.co_number2 = new System.Windows.Forms.Button();
            this.co_number1 = new System.Windows.Forms.Button();
            this.co_number6 = new System.Windows.Forms.Button();
            this.co_number5 = new System.Windows.Forms.Button();
            this.co_number4 = new System.Windows.Forms.Button();
            this.co_number9 = new System.Windows.Forms.Button();
            this.co_number8 = new System.Windows.Forms.Button();
            this.co_number7 = new System.Windows.Forms.Button();
            this.co_number_delete = new System.Windows.Forms.Button();
            this.co_cashin_confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.give_change_txt = new System.Windows.Forms.Label();
            this.order_check_btn = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(491, 520);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderNumber
            // 
            this.OrderNumber.AutoSize = true;
            this.OrderNumber.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderNumber.Location = new System.Drawing.Point(532, 47);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(142, 50);
            this.OrderNumber.TabIndex = 1;
            this.OrderNumber.Text = "單號：";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductName.Location = new System.Drawing.Point(532, 101);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(142, 50);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "品項：";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Price.Location = new System.Drawing.Point(532, 158);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(142, 50);
            this.Price.TabIndex = 3;
            this.Price.Text = "價格：";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Count.Location = new System.Drawing.Point(532, 215);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(142, 50);
            this.Count.TabIndex = 4;
            this.Count.Text = "數量：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(541, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(642, 204);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(532, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 50);
            this.label7.TabIndex = 9;
            this.label7.Text = "總價：";
            // 
            // TotalPrice_txt
            // 
            this.TotalPrice_txt.AutoSize = true;
            this.TotalPrice_txt.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPrice_txt.Location = new System.Drawing.Point(668, 491);
            this.TotalPrice_txt.Name = "TotalPrice_txt";
            this.TotalPrice_txt.Size = new System.Drawing.Size(45, 50);
            this.TotalPrice_txt.TabIndex = 10;
            this.TotalPrice_txt.Text = "0";
            // 
            // ProductCount_lab
            // 
            this.ProductCount_lab.Font = new System.Drawing.Font("新細明體", 20F);
            this.ProductCount_lab.Location = new System.Drawing.Point(677, 223);
            this.ProductCount_lab.Multiline = true;
            this.ProductCount_lab.Name = "ProductCount_lab";
            this.ProductCount_lab.Size = new System.Drawing.Size(114, 40);
            this.ProductCount_lab.TabIndex = 13;
            this.ProductCount_lab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(35, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "品項管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number7.Location = new System.Drawing.Point(903, 44);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(44, 45);
            this.number7.TabIndex = 15;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number8.Location = new System.Drawing.Point(953, 44);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(44, 45);
            this.number8.TabIndex = 16;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number9.Location = new System.Drawing.Point(1003, 44);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(44, 45);
            this.number9.TabIndex = 17;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number4.Location = new System.Drawing.Point(903, 95);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(44, 45);
            this.number4.TabIndex = 18;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number5.Location = new System.Drawing.Point(953, 95);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(44, 45);
            this.number5.TabIndex = 19;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number6.Location = new System.Drawing.Point(1003, 95);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(44, 45);
            this.number6.TabIndex = 20;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number1.Location = new System.Drawing.Point(903, 146);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(44, 45);
            this.number1.TabIndex = 21;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number2.Location = new System.Drawing.Point(953, 146);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(44, 45);
            this.number2.TabIndex = 22;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number3.Location = new System.Drawing.Point(1003, 146);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(44, 45);
            this.number3.TabIndex = 23;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number0.Location = new System.Drawing.Point(903, 197);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(44, 45);
            this.number0.TabIndex = 24;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // ProductCancel_btn
            // 
            this.ProductCancel_btn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductCancel_btn.Location = new System.Drawing.Point(1053, 44);
            this.ProductCancel_btn.Name = "ProductCancel_btn";
            this.ProductCancel_btn.Size = new System.Drawing.Size(44, 45);
            this.ProductCancel_btn.TabIndex = 26;
            this.ProductCancel_btn.Text = "清除";
            this.ProductCancel_btn.UseVisualStyleBackColor = true;
            this.ProductCancel_btn.Click += new System.EventHandler(this.ProductCancel_btn_Click);
            // 
            // ProductName_lab
            // 
            this.ProductName_lab.AutoSize = true;
            this.ProductName_lab.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.ProductName_lab.Location = new System.Drawing.Point(680, 114);
            this.ProductName_lab.Name = "ProductName_lab";
            this.ProductName_lab.Size = new System.Drawing.Size(0, 34);
            this.ProductName_lab.TabIndex = 27;
            // 
            // ProductPrice_lab
            // 
            this.ProductPrice_lab.AutoSize = true;
            this.ProductPrice_lab.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.ProductPrice_lab.Location = new System.Drawing.Point(680, 171);
            this.ProductPrice_lab.Name = "ProductPrice_lab";
            this.ProductPrice_lab.Size = new System.Drawing.Size(0, 34);
            this.ProductPrice_lab.TabIndex = 28;
            // 
            // Orderconfirm_btn
            // 
            this.Orderconfirm_btn.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.Orderconfirm_btn.Location = new System.Drawing.Point(1089, 644);
            this.Orderconfirm_btn.Name = "Orderconfirm_btn";
            this.Orderconfirm_btn.Size = new System.Drawing.Size(94, 45);
            this.Orderconfirm_btn.TabIndex = 29;
            this.Orderconfirm_btn.Text = "結帳";
            this.Orderconfirm_btn.UseVisualStyleBackColor = true;
            this.Orderconfirm_btn.Click += new System.EventHandler(this.Orderconfirm_btn_Click);
            // 
            // ProductConfirm_btn
            // 
            this.ProductConfirm_btn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductConfirm_btn.Location = new System.Drawing.Point(953, 197);
            this.ProductConfirm_btn.Name = "ProductConfirm_btn";
            this.ProductConfirm_btn.Size = new System.Drawing.Size(94, 45);
            this.ProductConfirm_btn.TabIndex = 30;
            this.ProductConfirm_btn.Text = "確定";
            this.ProductConfirm_btn.UseVisualStyleBackColor = true;
            this.ProductConfirm_btn.Click += new System.EventHandler(this.ProductConfirm_btn_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(413, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 31;
            this.button13.Text = "重載品項";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // OrderID_lab
            // 
            this.OrderID_lab.AutoSize = true;
            this.OrderID_lab.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.OrderID_lab.Location = new System.Drawing.Point(736, 60);
            this.OrderID_lab.Name = "OrderID_lab";
            this.OrderID_lab.Size = new System.Drawing.Size(0, 34);
            this.OrderID_lab.TabIndex = 32;
            // 
            // Order_delete_btn
            // 
            this.Order_delete_btn.ForeColor = System.Drawing.Color.Red;
            this.Order_delete_btn.Location = new System.Drawing.Point(1097, 220);
            this.Order_delete_btn.Name = "Order_delete_btn";
            this.Order_delete_btn.Size = new System.Drawing.Size(86, 45);
            this.Order_delete_btn.TabIndex = 33;
            this.Order_delete_btn.Text = "刪除";
            this.Order_delete_btn.UseVisualStyleBackColor = true;
            this.Order_delete_btn.Click += new System.EventHandler(this.Order_delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1136, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1137, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1137, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1137, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // cash_in_txt
            // 
            this.cash_in_txt.Font = new System.Drawing.Font("新細明體", 20F);
            this.cash_in_txt.Location = new System.Drawing.Point(677, 551);
            this.cash_in_txt.Multiline = true;
            this.cash_in_txt.Name = "cash_in_txt";
            this.cash_in_txt.Size = new System.Drawing.Size(114, 40);
            this.cash_in_txt.TabIndex = 40;
            this.cash_in_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(532, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 50);
            this.label5.TabIndex = 41;
            this.label5.Text = "收取：";
            // 
            // co_number0
            // 
            this.co_number0.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number0.Location = new System.Drawing.Point(820, 643);
            this.co_number0.Name = "co_number0";
            this.co_number0.Size = new System.Drawing.Size(44, 45);
            this.co_number0.TabIndex = 42;
            this.co_number0.Text = "0";
            this.co_number0.UseVisualStyleBackColor = true;
            this.co_number0.Click += new System.EventHandler(this.co_number0_Click);
            // 
            // co_number3
            // 
            this.co_number3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number3.Location = new System.Drawing.Point(920, 592);
            this.co_number3.Name = "co_number3";
            this.co_number3.Size = new System.Drawing.Size(44, 45);
            this.co_number3.TabIndex = 51;
            this.co_number3.Text = "3";
            this.co_number3.UseVisualStyleBackColor = true;
            this.co_number3.Click += new System.EventHandler(this.co_number3_Click);
            // 
            // co_number2
            // 
            this.co_number2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number2.Location = new System.Drawing.Point(870, 592);
            this.co_number2.Name = "co_number2";
            this.co_number2.Size = new System.Drawing.Size(44, 45);
            this.co_number2.TabIndex = 50;
            this.co_number2.Text = "2";
            this.co_number2.UseVisualStyleBackColor = true;
            this.co_number2.Click += new System.EventHandler(this.co_number2_Click);
            // 
            // co_number1
            // 
            this.co_number1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number1.Location = new System.Drawing.Point(820, 592);
            this.co_number1.Name = "co_number1";
            this.co_number1.Size = new System.Drawing.Size(44, 45);
            this.co_number1.TabIndex = 49;
            this.co_number1.Text = "1";
            this.co_number1.UseVisualStyleBackColor = true;
            this.co_number1.Click += new System.EventHandler(this.co_number1_Click);
            // 
            // co_number6
            // 
            this.co_number6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number6.Location = new System.Drawing.Point(920, 541);
            this.co_number6.Name = "co_number6";
            this.co_number6.Size = new System.Drawing.Size(44, 45);
            this.co_number6.TabIndex = 48;
            this.co_number6.Text = "6";
            this.co_number6.UseVisualStyleBackColor = true;
            this.co_number6.Click += new System.EventHandler(this.co_number6_Click);
            // 
            // co_number5
            // 
            this.co_number5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number5.Location = new System.Drawing.Point(870, 541);
            this.co_number5.Name = "co_number5";
            this.co_number5.Size = new System.Drawing.Size(44, 45);
            this.co_number5.TabIndex = 47;
            this.co_number5.Text = "5";
            this.co_number5.UseVisualStyleBackColor = true;
            this.co_number5.Click += new System.EventHandler(this.co_number5_Click);
            // 
            // co_number4
            // 
            this.co_number4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number4.Location = new System.Drawing.Point(820, 541);
            this.co_number4.Name = "co_number4";
            this.co_number4.Size = new System.Drawing.Size(44, 45);
            this.co_number4.TabIndex = 46;
            this.co_number4.Text = "4";
            this.co_number4.UseVisualStyleBackColor = true;
            this.co_number4.Click += new System.EventHandler(this.co_number4_Click);
            // 
            // co_number9
            // 
            this.co_number9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number9.Location = new System.Drawing.Point(920, 490);
            this.co_number9.Name = "co_number9";
            this.co_number9.Size = new System.Drawing.Size(44, 45);
            this.co_number9.TabIndex = 45;
            this.co_number9.Text = "9";
            this.co_number9.UseVisualStyleBackColor = true;
            this.co_number9.Click += new System.EventHandler(this.co_number9_Click);
            // 
            // co_number8
            // 
            this.co_number8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number8.Location = new System.Drawing.Point(870, 490);
            this.co_number8.Name = "co_number8";
            this.co_number8.Size = new System.Drawing.Size(44, 45);
            this.co_number8.TabIndex = 44;
            this.co_number8.Text = "8";
            this.co_number8.UseVisualStyleBackColor = true;
            this.co_number8.Click += new System.EventHandler(this.co_number8_Click);
            // 
            // co_number7
            // 
            this.co_number7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number7.Location = new System.Drawing.Point(820, 490);
            this.co_number7.Name = "co_number7";
            this.co_number7.Size = new System.Drawing.Size(44, 45);
            this.co_number7.TabIndex = 43;
            this.co_number7.Text = "7";
            this.co_number7.UseVisualStyleBackColor = true;
            this.co_number7.Click += new System.EventHandler(this.co_number7_Click);
            // 
            // co_number_delete
            // 
            this.co_number_delete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_number_delete.Location = new System.Drawing.Point(970, 490);
            this.co_number_delete.Name = "co_number_delete";
            this.co_number_delete.Size = new System.Drawing.Size(44, 45);
            this.co_number_delete.TabIndex = 52;
            this.co_number_delete.Text = "清除";
            this.co_number_delete.UseVisualStyleBackColor = true;
            this.co_number_delete.Click += new System.EventHandler(this.co_number_delete_Click);
            // 
            // co_cashin_confirm
            // 
            this.co_cashin_confirm.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.co_cashin_confirm.Location = new System.Drawing.Point(870, 643);
            this.co_cashin_confirm.Name = "co_cashin_confirm";
            this.co_cashin_confirm.Size = new System.Drawing.Size(94, 45);
            this.co_cashin_confirm.TabIndex = 53;
            this.co_cashin_confirm.Text = "確定";
            this.co_cashin_confirm.UseVisualStyleBackColor = true;
            this.co_cashin_confirm.Click += new System.EventHandler(this.co_cashin_confirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(532, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 50);
            this.label6.TabIndex = 54;
            this.label6.Text = "找零：";
            // 
            // give_change_txt
            // 
            this.give_change_txt.AutoSize = true;
            this.give_change_txt.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.give_change_txt.Location = new System.Drawing.Point(668, 602);
            this.give_change_txt.Name = "give_change_txt";
            this.give_change_txt.Size = new System.Drawing.Size(0, 50);
            this.give_change_txt.TabIndex = 55;
            // 
            // order_check_btn
            // 
            this.order_check_btn.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.order_check_btn.Location = new System.Drawing.Point(175, 44);
            this.order_check_btn.Name = "order_check_btn";
            this.order_check_btn.Size = new System.Drawing.Size(134, 43);
            this.order_check_btn.TabIndex = 56;
            this.order_check_btn.Text = "訂單管理";
            this.order_check_btn.UseVisualStyleBackColor = true;
            this.order_check_btn.Click += new System.EventHandler(this.order_check_btn_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "品項編號";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "名稱";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "種類";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "單價";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1210, 736);
            this.Controls.Add(this.order_check_btn);
            this.Controls.Add(this.give_change_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.co_cashin_confirm);
            this.Controls.Add(this.co_number_delete);
            this.Controls.Add(this.co_number3);
            this.Controls.Add(this.co_number2);
            this.Controls.Add(this.co_number1);
            this.Controls.Add(this.co_number6);
            this.Controls.Add(this.co_number5);
            this.Controls.Add(this.co_number4);
            this.Controls.Add(this.co_number9);
            this.Controls.Add(this.co_number8);
            this.Controls.Add(this.co_number7);
            this.Controls.Add(this.co_number0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cash_in_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_delete_btn);
            this.Controls.Add(this.OrderID_lab);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.ProductConfirm_btn);
            this.Controls.Add(this.Orderconfirm_btn);
            this.Controls.Add(this.ProductPrice_lab);
            this.Controls.Add(this.ProductName_lab);
            this.Controls.Add(this.ProductCancel_btn);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductCount_lab);
            this.Controls.Add(this.TotalPrice_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "OrderSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label OrderNumber;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalPrice_txt;
        private System.Windows.Forms.TextBox ProductCount_lab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button ProductCancel_btn;
        private System.Windows.Forms.Label ProductName_lab;
        private System.Windows.Forms.Label ProductPrice_lab;
        private System.Windows.Forms.Button Orderconfirm_btn;
        private System.Windows.Forms.Button ProductConfirm_btn;
        private StoreDataSet storeDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private StoreDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label OrderID_lab;
        private System.Windows.Forms.Button Order_delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cash_in_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button co_number0;
        private System.Windows.Forms.Button co_number3;
        private System.Windows.Forms.Button co_number2;
        private System.Windows.Forms.Button co_number1;
        private System.Windows.Forms.Button co_number6;
        private System.Windows.Forms.Button co_number5;
        private System.Windows.Forms.Button co_number4;
        private System.Windows.Forms.Button co_number9;
        private System.Windows.Forms.Button co_number8;
        private System.Windows.Forms.Button co_number7;
        private System.Windows.Forms.Button co_number_delete;
        private System.Windows.Forms.Button co_cashin_confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label give_change_txt;
        private System.Windows.Forms.Button order_check_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

