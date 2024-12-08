namespace Wholesale_electronic_shop
{
    partial class deleteproduct
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
            this.pnl_Search_Employee = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Search_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Search_Employee
            // 
            this.pnl_Search_Employee.BackColor = System.Drawing.Color.Gray;
            this.pnl_Search_Employee.Controls.Add(this.button1);
            this.pnl_Search_Employee.Controls.Add(this.lbl_Product_Id);
            this.pnl_Search_Employee.Controls.Add(this.product_id);
            this.pnl_Search_Employee.Controls.Add(this.btn_Search);
            this.pnl_Search_Employee.Location = new System.Drawing.Point(13, 13);
            this.pnl_Search_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search_Employee.Name = "pnl_Search_Employee";
            this.pnl_Search_Employee.Size = new System.Drawing.Size(981, 62);
            this.pnl_Search_Employee.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(762, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 60;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Id.Location = new System.Drawing.Point(4, 16);
            this.lbl_Product_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(129, 31);
            this.lbl_Product_Id.TabIndex = 1;
            this.lbl_Product_Id.Text = "Product ID";
            // 
            // product_id
            // 
            this.product_id.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(207, 11);
            this.product_id.Margin = new System.Windows.Forms.Padding(4);
            this.product_id.MaxLength = 10;
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(275, 42);
            this.product_id.TabIndex = 2;
            this.product_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Employee_Id_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(602, 8);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 49);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 471);
            this.dataGridView1.TabIndex = 64;
            // 
            // deleteproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1082, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_Search_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteproduct";
            this.Text = "deleteproduct";
            this.Load += new System.EventHandler(this.deleteproduct_Load);
            this.pnl_Search_Employee.ResumeLayout(false);
            this.pnl_Search_Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Search_Employee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.TextBox product_id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}