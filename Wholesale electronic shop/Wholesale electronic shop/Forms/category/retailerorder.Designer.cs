namespace Wholesale_electronic_shop
{
    partial class retailerorder
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
            this.retailerbill = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Pricer = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.Subcategoryr = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.Quantityr = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.Product_Namer = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.Categoryr = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.stock_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.Label();
            this.retailerinfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retailername = new System.Windows.Forms.ComboBox();
            this.dbill_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.retailerbill)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.retailerinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(873, 527);
            this.tb_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Bill.MaxLength = 80;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.ReadOnly = true;
            this.tb_Total_Bill.Size = new System.Drawing.Size(122, 39);
            this.tb_Total_Bill.TabIndex = 89;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.White;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(747, 530);
            this.lbl_Total_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(109, 31);
            this.lbl_Total_Bill.TabIndex = 96;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(707, 580);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 50);
            this.btn_Refresh.TabIndex = 91;
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
            this.btn_Save.Location = new System.Drawing.Point(855, 580);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 50);
            this.btn_Save.TabIndex = 90;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // retailerbill
            // 
            this.retailerbill.AllowUserToAddRows = false;
            this.retailerbill.BackgroundColor = System.Drawing.Color.White;
            this.retailerbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retailerbill.Location = new System.Drawing.Point(36, 327);
            this.retailerbill.Margin = new System.Windows.Forms.Padding(4);
            this.retailerbill.Name = "retailerbill";
            this.retailerbill.RowHeadersWidth = 51;
            this.retailerbill.Size = new System.Drawing.Size(957, 184);
            this.retailerbill.TabIndex = 92;
            this.retailerbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.retailerbill_CellClick);
            this.retailerbill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.retailerbill_RowPostPaint);
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
            // Pricer
            // 
            this.Pricer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pricer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricer.Location = new System.Drawing.Point(611, 93);
            this.Pricer.Margin = new System.Windows.Forms.Padding(4);
            this.Pricer.MaxLength = 80;
            this.Pricer.Name = "Pricer";
            this.Pricer.ReadOnly = true;
            this.Pricer.Size = new System.Drawing.Size(209, 34);
            this.Pricer.TabIndex = 10;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Price.Location = new System.Drawing.Point(438, 99);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(158, 31);
            this.lbl_Price.TabIndex = 83;
            this.lbl_Price.Text = "Product Price";
            // 
            // Subcategoryr
            // 
            this.Subcategoryr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Subcategoryr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subcategoryr.FormattingEnabled = true;
            this.Subcategoryr.Location = new System.Drawing.Point(611, 34);
            this.Subcategoryr.Margin = new System.Windows.Forms.Padding(4);
            this.Subcategoryr.Name = "Subcategoryr";
            this.Subcategoryr.Size = new System.Drawing.Size(209, 36);
            this.Subcategoryr.TabIndex = 8;
            this.Subcategoryr.SelectedIndexChanged += new System.EventHandler(this.Subcategoryr_SelectedIndexChanged);
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.ForeColor = System.Drawing.Color.White;
            this.lbl_Subcategory.Location = new System.Drawing.Point(438, 35);
            this.lbl_Subcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(149, 31);
            this.lbl_Subcategory.TabIndex = 82;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // Quantityr
            // 
            this.Quantityr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Quantityr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantityr.Location = new System.Drawing.Point(190, 157);
            this.Quantityr.Margin = new System.Windows.Forms.Padding(4);
            this.Quantityr.MaxLength = 80;
            this.Quantityr.Name = "Quantityr";
            this.Quantityr.Size = new System.Drawing.Size(224, 34);
            this.Quantityr.TabIndex = 11;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_Quantity.Location = new System.Drawing.Point(20, 154);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(108, 31);
            this.lbl_Quantity.TabIndex = 79;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // Product_Namer
            // 
            this.Product_Namer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Product_Namer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Namer.ForeColor = System.Drawing.Color.Black;
            this.Product_Namer.FormattingEnabled = true;
            this.Product_Namer.Location = new System.Drawing.Point(191, 98);
            this.Product_Namer.Margin = new System.Windows.Forms.Padding(4);
            this.Product_Namer.Name = "Product_Namer";
            this.Product_Namer.Size = new System.Drawing.Size(225, 36);
            this.Product_Namer.TabIndex = 9;
            this.Product_Namer.SelectedIndexChanged += new System.EventHandler(this.Product_Namer_SelectedIndexChanged);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(3, 103);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(168, 31);
            this.lbl_Product_Name.TabIndex = 78;
            this.lbl_Product_Name.Text = "Product Name";
            this.lbl_Product_Name.Click += new System.EventHandler(this.lbl_Product_Name_Click);
            // 
            // Categoryr
            // 
            this.Categoryr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Categoryr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoryr.FormattingEnabled = true;
            this.Categoryr.Location = new System.Drawing.Point(191, 34);
            this.Categoryr.Margin = new System.Windows.Forms.Padding(4);
            this.Categoryr.Name = "Categoryr";
            this.Categoryr.Size = new System.Drawing.Size(225, 36);
            this.Categoryr.TabIndex = 7;
            this.Categoryr.SelectedIndexChanged += new System.EventHandler(this.Categoryr_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(17, 40);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(111, 31);
            this.lbl_Category.TabIndex = 77;
            this.lbl_Category.Text = "Category";
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.DimGray;
            this.gb_Product_Details.Controls.Add(this.stock_quantity);
            this.gb_Product_Details.Controls.Add(this.label1);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.Pricer);
            this.gb_Product_Details.Controls.Add(this.lbl_Price);
            this.gb_Product_Details.Controls.Add(this.Subcategoryr);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory);
            this.gb_Product_Details.Controls.Add(this.Quantityr);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.Product_Namer);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.Categoryr);
            this.gb_Product_Details.Controls.Add(this.lbl_Category);
            this.gb_Product_Details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(36, 98);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(957, 222);
            this.gb_Product_Details.TabIndex = 85;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Enter += new System.EventHandler(this.gb_Product_Details_Enter);
            // 
            // stock_quantity
            // 
            this.stock_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stock_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_quantity.Location = new System.Drawing.Point(611, 157);
            this.stock_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.stock_quantity.MaxLength = 80;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            this.stock_quantity.Size = new System.Drawing.Size(209, 34);
            this.stock_quantity.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 87;
            this.label1.Text = "Stock Quantity";
            // 
            // rname
            // 
            this.rname.AutoSize = true;
            this.rname.BackColor = System.Drawing.Color.Transparent;
            this.rname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rname.ForeColor = System.Drawing.Color.White;
            this.rname.Location = new System.Drawing.Point(23, 28);
            this.rname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(165, 31);
            this.rname.TabIndex = 64;
            this.rname.Text = "Retailer Name";
            // 
            // retailerinfo
            // 
            this.retailerinfo.BackColor = System.Drawing.Color.DimGray;
            this.retailerinfo.Controls.Add(this.dateTimePicker1);
            this.retailerinfo.Controls.Add(this.label2);
            this.retailerinfo.Controls.Add(this.retailername);
            this.retailerinfo.Controls.Add(this.rname);
            this.retailerinfo.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailerinfo.Location = new System.Drawing.Point(36, 12);
            this.retailerinfo.Name = "retailerinfo";
            this.retailerinfo.Size = new System.Drawing.Size(957, 80);
            this.retailerinfo.TabIndex = 84;
            this.retailerinfo.TabStop = false;
            this.retailerinfo.Enter += new System.EventHandler(this.gb_Customer_Details_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(615, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "Bill Date ";
            // 
            // retailername
            // 
            this.retailername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailername.FormattingEnabled = true;
            this.retailername.Location = new System.Drawing.Point(205, 27);
            this.retailername.Name = "retailername";
            this.retailername.Size = new System.Drawing.Size(316, 36);
            this.retailername.TabIndex = 66;
            this.retailername.SelectedIndexChanged += new System.EventHandler(this.retailername_SelectedIndexChanged);
            this.retailername.SelectedValueChanged += new System.EventHandler(this.retailername_SelectedValueChanged);
            // 
            // dbill_no
            // 
            this.dbill_no.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbill_no.Location = new System.Drawing.Point(137, 532);
            this.dbill_no.Margin = new System.Windows.Forms.Padding(4);
            this.dbill_no.MaxLength = 80;
            this.dbill_no.Name = "dbill_no";
            this.dbill_no.ReadOnly = true;
            this.dbill_no.Size = new System.Drawing.Size(87, 39);
            this.dbill_no.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 98;
            this.label3.Text = "Bill No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(734, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // retailerorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1021, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbill_no);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.retailerbill);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.retailerinfo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "retailerorder";
            this.Text = "retailerorder";
            this.Load += new System.EventHandler(this.retailerorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retailerbill)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.retailerinfo.ResumeLayout(false);
            this.retailerinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView retailerbill;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox Pricer;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.ComboBox Subcategoryr;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.TextBox Quantityr;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.ComboBox Product_Namer;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox Categoryr;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.Label rname;
        private System.Windows.Forms.GroupBox retailerinfo;
        private System.Windows.Forms.TextBox stock_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox retailername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbill_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}