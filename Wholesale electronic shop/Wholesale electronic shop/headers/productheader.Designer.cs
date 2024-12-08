namespace Wholesale_electronic_shop
{
    partial class productheader
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
            this.searchproduct = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.updateproduct = new System.Windows.Forms.Button();
            this.Viewproduct = new System.Windows.Forms.Button();
            this.categorym = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchproduct
            // 
            this.searchproduct.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchproduct.ForeColor = System.Drawing.Color.Black;
            this.searchproduct.Location = new System.Drawing.Point(249, 110);
            this.searchproduct.Name = "searchproduct";
            this.searchproduct.Size = new System.Drawing.Size(190, 37);
            this.searchproduct.TabIndex = 23;
            this.searchproduct.Text = "Search Product";
            this.searchproduct.UseVisualStyleBackColor = true;
            this.searchproduct.Click += new System.EventHandler(this.searchproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteproduct.ForeColor = System.Drawing.Color.Black;
            this.deleteproduct.Location = new System.Drawing.Point(696, 110);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(170, 37);
            this.deleteproduct.TabIndex = 22;
            this.deleteproduct.Text = "Delete Product";
            this.deleteproduct.UseVisualStyleBackColor = true;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateproduct.ForeColor = System.Drawing.Color.Black;
            this.updateproduct.Location = new System.Drawing.Point(472, 110);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(192, 37);
            this.updateproduct.TabIndex = 21;
            this.updateproduct.Text = "Update Product";
            this.updateproduct.UseVisualStyleBackColor = true;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // Viewproduct
            // 
            this.Viewproduct.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewproduct.ForeColor = System.Drawing.Color.Black;
            this.Viewproduct.Location = new System.Drawing.Point(77, 111);
            this.Viewproduct.Name = "Viewproduct";
            this.Viewproduct.Size = new System.Drawing.Size(143, 37);
            this.Viewproduct.TabIndex = 20;
            this.Viewproduct.Text = "Add Product";
            this.Viewproduct.UseVisualStyleBackColor = true;
            this.Viewproduct.Click += new System.EventHandler(this.Viewproduct_Click);
            // 
            // categorym
            // 
            this.categorym.AutoSize = true;
            this.categorym.BackColor = System.Drawing.Color.Black;
            this.categorym.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorym.ForeColor = System.Drawing.Color.White;
            this.categorym.Location = new System.Drawing.Point(351, 31);
            this.categorym.Name = "categorym";
            this.categorym.Size = new System.Drawing.Size(202, 62);
            this.categorym.TabIndex = 19;
            this.categorym.Text = "Product";
            // 
            // productheader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 158);
            this.Controls.Add(this.searchproduct);
            this.Controls.Add(this.deleteproduct);
            this.Controls.Add(this.updateproduct);
            this.Controls.Add(this.Viewproduct);
            this.Controls.Add(this.categorym);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productheader";
            this.Text = "productheader";
            this.Load += new System.EventHandler(this.productheader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchproduct;
        private System.Windows.Forms.Button deleteproduct;
        private System.Windows.Forms.Button updateproduct;
        private System.Windows.Forms.Button Viewproduct;
        private System.Windows.Forms.Label categorym;
    }
}