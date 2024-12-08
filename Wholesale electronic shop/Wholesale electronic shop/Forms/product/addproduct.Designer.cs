namespace Wholesale_electronic_shop
{
    partial class addproduct
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
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.Subcatgory_Name = new System.Windows.Forms.ComboBox();
            this.Category_Name = new System.Windows.Forms.ComboBox();
            this.tb_GST_Apllied = new System.Windows.Forms.TextBox();
            this.lbl_Gst_Apllied = new System.Windows.Forms.Label();
            this.dtp_Add_Product_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(784, 29);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sales_Price.MaxLength = 10;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(287, 34);
            this.tb_Sales_Price.TabIndex = 74;
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sales_Price_KeyPress);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(784, 288);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Purchase_Price.MaxLength = 10;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(287, 34);
            this.tb_Purchase_Price.TabIndex = 75;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Price_KeyPress);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(567, 291);
            this.lbl_Purchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(150, 28);
            this.lbl_Purchase_Price.TabIndex = 76;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Sales_Price.Location = new System.Drawing.Point(565, 29);
            this.lbl_Sales_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(113, 28);
            this.lbl_Sales_Price.TabIndex = 77;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(784, 366);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Description.MaxLength = 120;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(287, 106);
            this.tb_Description.TabIndex = 64;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.White;
            this.lbl_Description.Location = new System.Drawing.Point(567, 375);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(121, 28);
            this.lbl_Description.TabIndex = 73;
            this.lbl_Description.Text = "Description";
            // 
            // Subcatgory_Name
            // 
            this.Subcatgory_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subcatgory_Name.FormattingEnabled = true;
            this.Subcatgory_Name.Location = new System.Drawing.Point(229, 193);
            this.Subcatgory_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Subcatgory_Name.MaxLength = 40;
            this.Subcatgory_Name.Name = "Subcatgory_Name";
            this.Subcatgory_Name.Size = new System.Drawing.Size(264, 36);
            this.Subcatgory_Name.TabIndex = 58;
            this.Subcatgory_Name.SelectedIndexChanged += new System.EventHandler(this.Subcatgory_Name_SelectedIndexChanged);
            // 
            // Category_Name
            // 
            this.Category_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.FormattingEnabled = true;
            this.Category_Name.Location = new System.Drawing.Point(229, 111);
            this.Category_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Category_Name.MaxLength = 40;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(264, 36);
            this.Category_Name.TabIndex = 57;
            this.Category_Name.SelectedIndexChanged += new System.EventHandler(this.Category_Name_SelectedIndexChanged);
            this.Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Category_Name_KeyPress);
            // 
            // tb_GST_Apllied
            // 
            this.tb_GST_Apllied.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST_Apllied.Location = new System.Drawing.Point(784, 115);
            this.tb_GST_Apllied.Margin = new System.Windows.Forms.Padding(4);
            this.tb_GST_Apllied.MaxLength = 5;
            this.tb_GST_Apllied.Name = "tb_GST_Apllied";
            this.tb_GST_Apllied.Size = new System.Drawing.Size(287, 34);
            this.tb_GST_Apllied.TabIndex = 62;
            this.tb_GST_Apllied.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_GST_Apllied_KeyPress);
            // 
            // lbl_Gst_Apllied
            // 
            this.lbl_Gst_Apllied.AutoSize = true;
            this.lbl_Gst_Apllied.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gst_Apllied.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gst_Apllied.ForeColor = System.Drawing.Color.White;
            this.lbl_Gst_Apllied.Location = new System.Drawing.Point(565, 120);
            this.lbl_Gst_Apllied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gst_Apllied.Name = "lbl_Gst_Apllied";
            this.lbl_Gst_Apllied.Size = new System.Drawing.Size(122, 28);
            this.lbl_Gst_Apllied.TabIndex = 72;
            this.lbl_Gst_Apllied.Text = "Gst Applied";
            // 
            // dtp_Add_Product_Date
            // 
            this.dtp_Add_Product_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Add_Product_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Add_Product_Date.Location = new System.Drawing.Point(229, 374);
            this.dtp_Add_Product_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Add_Product_Date.Name = "dtp_Add_Product_Date";
            this.dtp_Add_Product_Date.Size = new System.Drawing.Size(264, 34);
            this.dtp_Add_Product_Date.TabIndex = 60;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(22, 369);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(57, 28);
            this.lbl_Date.TabIndex = 70;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(557, 200);
            this.lbl_Distributor_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(178, 28);
            this.lbl_Distributor_Name.TabIndex = 69;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(229, 280);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Name.MaxLength = 60;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(264, 34);
            this.tb_Product_Name.TabIndex = 59;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Name_KeyPress);
            this.tb_Product_Name.Leave += new System.EventHandler(this.tb_Product_Name_Leave);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(23, 279);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(148, 28);
            this.lbl_Product_Name.TabIndex = 68;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // Product_ID
            // 
            this.Product_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_ID.Location = new System.Drawing.Point(229, 29);
            this.Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Product_ID.MaxLength = 5;
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(264, 34);
            this.Product_ID.TabIndex = 56;
            this.Product_ID.TextChanged += new System.EventHandler(this.Product_ID_TextChanged);
            this.Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_ID_KeyPress);
            this.Product_ID.Leave += new System.EventHandler(this.Product_ID_Leave);
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Id.Location = new System.Drawing.Point(22, 29);
            this.lbl_Product_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(113, 28);
            this.lbl_Product_Id.TabIndex = 67;
            this.lbl_Product_Id.Text = "Product ID";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(22, 194);
            this.lbl_Subcategory_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(193, 28);
            this.lbl_Subcategory_Name.TabIndex = 66;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Category_Name.Location = new System.Drawing.Point(22, 111);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(160, 28);
            this.lbl_Category_Name.TabIndex = 65;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(229, 536);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(185, 55);
            this.btn_Refresh.TabIndex = 79;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(615, 536);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(167, 55);
            this.btn_Save.TabIndex = 78;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Distributor_Name
            // 
            this.tb_Distributor_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_Name.FormattingEnabled = true;
            this.tb_Distributor_Name.Location = new System.Drawing.Point(784, 197);
            this.tb_Distributor_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Distributor_Name.MaxLength = 40;
            this.tb_Distributor_Name.Name = "tb_Distributor_Name";
            this.tb_Distributor_Name.Size = new System.Drawing.Size(264, 36);
            this.tb_Distributor_Name.TabIndex = 80;
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1101, 616);
            this.Controls.Add(this.tb_Distributor_Name);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Sales_Price);
            this.Controls.Add(this.tb_Purchase_Price);
            this.Controls.Add(this.lbl_Purchase_Price);
            this.Controls.Add(this.lbl_Sales_Price);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.Subcatgory_Name);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.tb_GST_Apllied);
            this.Controls.Add(this.lbl_Gst_Apllied);
            this.Controls.Add(this.dtp_Add_Product_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Distributor_Name);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.Product_ID);
            this.Controls.Add(this.lbl_Product_Id);
            this.Controls.Add(this.lbl_Subcategory_Name);
            this.Controls.Add(this.lbl_Category_Name);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addproduct";
            this.Text = "addproduct";
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.ComboBox Subcatgory_Name;
        private System.Windows.Forms.ComboBox Category_Name;
        private System.Windows.Forms.TextBox tb_GST_Apllied;
        private System.Windows.Forms.Label lbl_Gst_Apllied;
        private System.Windows.Forms.DateTimePicker dtp_Add_Product_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox tb_Distributor_Name;
    }
}