namespace Wholesale_electronic_shop
{
    partial class addstock
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
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.DataGridView();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.stock_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.subcategoryn = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.Product_Namen = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cateogryn = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.disname = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.distributor_name = new System.Windows.Forms.ComboBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bill_no = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.disname.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(845, 527);
            this.tb_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Bill.MaxLength = 80;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.ReadOnly = true;
            this.tb_Total_Bill.Size = new System.Drawing.Size(122, 39);
            this.tb_Total_Bill.TabIndex = 102;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.White;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(719, 530);
            this.lbl_Total_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(109, 31);
            this.lbl_Total_Bill.TabIndex = 109;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(677, 583);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 50);
            this.btn_Refresh.TabIndex = 104;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(825, 583);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 50);
            this.btn_Save.TabIndex = 103;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // bill
            // 
            this.bill.BackgroundColor = System.Drawing.Color.White;
            this.bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill.Location = new System.Drawing.Point(8, 327);
            this.bill.Margin = new System.Windows.Forms.Padding(4);
            this.bill.Name = "bill";
            this.bill.RowHeadersWidth = 51;
            this.bill.Size = new System.Drawing.Size(957, 184);
            this.bill.TabIndex = 105;
            this.bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_CellClick);
            this.bill.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.bill_CellPainting);
            this.bill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.bill_RowPostPaint);
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.DimGray;
            this.gb_Product_Details.Controls.Add(this.stock_quantity);
            this.gb_Product_Details.Controls.Add(this.label1);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Price);
            this.gb_Product_Details.Controls.Add(this.subcategoryn);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory);
            this.gb_Product_Details.Controls.Add(this.Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.Product_Namen);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.cateogryn);
            this.gb_Product_Details.Controls.Add(this.lbl_Category);
            this.gb_Product_Details.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(8, 107);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(957, 213);
            this.gb_Product_Details.TabIndex = 98;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Enter += new System.EventHandler(this.gb_Product_Details_Enter);
            // 
            // stock_quantity
            // 
            this.stock_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stock_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_quantity.Location = new System.Drawing.Point(611, 159);
            this.stock_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.stock_quantity.MaxLength = 80;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            this.stock_quantity.Size = new System.Drawing.Size(209, 34);
            this.stock_quantity.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 85;
            this.label1.Text = "Remaining Stock";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(834, 28);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 50);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(611, 96);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.MaxLength = 80;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(209, 34);
            this.Price.TabIndex = 10;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Price.Location = new System.Drawing.Point(438, 96);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(158, 31);
            this.lbl_Price.TabIndex = 83;
            this.lbl_Price.Text = "Product Price";
            // 
            // subcategoryn
            // 
            this.subcategoryn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.subcategoryn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcategoryn.FormattingEnabled = true;
            this.subcategoryn.Location = new System.Drawing.Point(611, 37);
            this.subcategoryn.Margin = new System.Windows.Forms.Padding(4);
            this.subcategoryn.Name = "subcategoryn";
            this.subcategoryn.Size = new System.Drawing.Size(209, 36);
            this.subcategoryn.TabIndex = 8;
            this.subcategoryn.SelectedIndexChanged += new System.EventHandler(this.subcategoryn_SelectedIndexChanged);
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.ForeColor = System.Drawing.Color.White;
            this.lbl_Subcategory.Location = new System.Drawing.Point(438, 38);
            this.lbl_Subcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(149, 31);
            this.lbl_Subcategory.TabIndex = 82;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(191, 156);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity.MaxLength = 80;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(224, 34);
            this.Quantity.TabIndex = 11;
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_Quantity.Location = new System.Drawing.Point(20, 161);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(108, 31);
            this.lbl_Quantity.TabIndex = 79;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // Product_Namen
            // 
            this.Product_Namen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Product_Namen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Namen.ForeColor = System.Drawing.Color.Black;
            this.Product_Namen.FormattingEnabled = true;
            this.Product_Namen.Location = new System.Drawing.Point(190, 96);
            this.Product_Namen.Margin = new System.Windows.Forms.Padding(4);
            this.Product_Namen.Name = "Product_Namen";
            this.Product_Namen.Size = new System.Drawing.Size(225, 36);
            this.Product_Namen.TabIndex = 9;
            this.Product_Namen.SelectedIndexChanged += new System.EventHandler(this.Product_Namen_SelectedIndexChanged);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(3, 96);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(168, 31);
            this.lbl_Product_Name.TabIndex = 78;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cateogryn
            // 
            this.cateogryn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cateogryn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateogryn.FormattingEnabled = true;
            this.cateogryn.Location = new System.Drawing.Point(191, 37);
            this.cateogryn.Margin = new System.Windows.Forms.Padding(4);
            this.cateogryn.Name = "cateogryn";
            this.cateogryn.Size = new System.Drawing.Size(225, 36);
            this.cateogryn.TabIndex = 7;
            this.cateogryn.SelectedIndexChanged += new System.EventHandler(this.cateogryn_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(17, 27);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(111, 31);
            this.lbl_Category.TabIndex = 77;
            this.lbl_Category.Text = "Category";
            // 
            // disname
            // 
            this.disname.BackColor = System.Drawing.Color.DimGray;
            this.disname.Controls.Add(this.dateTimePicker1);
            this.disname.Controls.Add(this.label2);
            this.disname.Controls.Add(this.distributor_name);
            this.disname.Controls.Add(this.lbl_Customer_ID);
            this.disname.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disname.Location = new System.Drawing.Point(8, 12);
            this.disname.Name = "disname";
            this.disname.Size = new System.Drawing.Size(957, 89);
            this.disname.TabIndex = 97;
            this.disname.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(650, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "Bill Date ";
            // 
            // distributor_name
            // 
            this.distributor_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.distributor_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributor_name.FormattingEnabled = true;
            this.distributor_name.Location = new System.Drawing.Point(236, 32);
            this.distributor_name.Margin = new System.Windows.Forms.Padding(4);
            this.distributor_name.Name = "distributor_name";
            this.distributor_name.Size = new System.Drawing.Size(363, 36);
            this.distributor_name.TabIndex = 66;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(34, 34);
            this.lbl_Customer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(194, 30);
            this.lbl_Customer_ID.TabIndex = 64;
            this.lbl_Customer_ID.Text = "Distributor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 530);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 111;
            this.label3.Text = "Bill No";
            // 
            // bill_no
            // 
            this.bill_no.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_no.Location = new System.Drawing.Point(114, 527);
            this.bill_no.Margin = new System.Windows.Forms.Padding(4);
            this.bill_no.MaxLength = 80;
            this.bill_no.Name = "bill_no";
            this.bill_no.ReadOnly = true;
            this.bill_no.Size = new System.Drawing.Size(87, 39);
            this.bill_no.TabIndex = 110;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(769, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 30);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(977, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bill_no);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.disname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addstock";
            this.Text = "addstock";
            this.Load += new System.EventHandler(this.addstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.disname.ResumeLayout(false);
            this.disname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView bill;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.ComboBox subcategoryn;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.ComboBox Product_Namen;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cateogryn;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.GroupBox disname;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.TextBox stock_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox distributor_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bill_no;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}