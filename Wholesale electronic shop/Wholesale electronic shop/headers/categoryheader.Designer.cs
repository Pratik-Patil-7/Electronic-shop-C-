namespace Wholesale_electronic_shop
{
    partial class categoryheader
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
            this.addstock = new System.Windows.Forms.Button();
            this.Addsubc = new System.Windows.Forms.Button();
            this.retailerorder = new System.Windows.Forms.Button();
            this.categorym = new System.Windows.Forms.Label();
            this.addcategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addstock
            // 
            this.addstock.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstock.ForeColor = System.Drawing.Color.Black;
            this.addstock.Location = new System.Drawing.Point(756, 113);
            this.addstock.Name = "addstock";
            this.addstock.Size = new System.Drawing.Size(143, 37);
            this.addstock.TabIndex = 7;
            this.addstock.Text = "Add Stock";
            this.addstock.UseVisualStyleBackColor = true;
            this.addstock.Click += new System.EventHandler(this.addstock_Click);
            // 
            // Addsubc
            // 
            this.Addsubc.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsubc.ForeColor = System.Drawing.Color.Black;
            this.Addsubc.Location = new System.Drawing.Point(311, 113);
            this.Addsubc.Name = "Addsubc";
            this.Addsubc.Size = new System.Drawing.Size(169, 37);
            this.Addsubc.TabIndex = 8;
            this.Addsubc.Text = "Add Subcategory";
            this.Addsubc.UseVisualStyleBackColor = true;
            this.Addsubc.Click += new System.EventHandler(this.Addsubc_Click);
            // 
            // retailerorder
            // 
            this.retailerorder.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailerorder.ForeColor = System.Drawing.Color.Black;
            this.retailerorder.Location = new System.Drawing.Point(539, 113);
            this.retailerorder.Name = "retailerorder";
            this.retailerorder.Size = new System.Drawing.Size(143, 37);
            this.retailerorder.TabIndex = 6;
            this.retailerorder.Text = "Retailer Order";
            this.retailerorder.UseVisualStyleBackColor = true;
            this.retailerorder.Click += new System.EventHandler(this.retailerorder_Click);
            // 
            // categorym
            // 
            this.categorym.AutoSize = true;
            this.categorym.BackColor = System.Drawing.Color.Black;
            this.categorym.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorym.ForeColor = System.Drawing.Color.White;
            this.categorym.Location = new System.Drawing.Point(400, 24);
            this.categorym.Name = "categorym";
            this.categorym.Size = new System.Drawing.Size(228, 62);
            this.categorym.TabIndex = 4;
            this.categorym.Text = "Category";
            // 
            // addcategory
            // 
            this.addcategory.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategory.ForeColor = System.Drawing.Color.Black;
            this.addcategory.Location = new System.Drawing.Point(104, 113);
            this.addcategory.Name = "addcategory";
            this.addcategory.Size = new System.Drawing.Size(143, 37);
            this.addcategory.TabIndex = 5;
            this.addcategory.Text = "Add Category";
            this.addcategory.UseVisualStyleBackColor = true;
            this.addcategory.Click += new System.EventHandler(this.addcategory_Click);
            this.addcategory.MouseLeave += new System.EventHandler(this.addcategory_MouseLeave);
            // 
            // categoryheader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1003, 175);
            this.Controls.Add(this.addstock);
            this.Controls.Add(this.Addsubc);
            this.Controls.Add(this.retailerorder);
            this.Controls.Add(this.categorym);
            this.Controls.Add(this.addcategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryheader";
            this.Text = "categoryheader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addstock;
        private System.Windows.Forms.Button Addsubc;
        private System.Windows.Forms.Button retailerorder;
        private System.Windows.Forms.Label categorym;
        private System.Windows.Forms.Button addcategory;
    }
}