namespace Wholesale_electronic_shop
{
    partial class retailerheader
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
            this.categorym = new System.Windows.Forms.Label();
            this.Adddistributor = new System.Windows.Forms.Button();
            this.updateretailer = new System.Windows.Forms.Button();
            this.deleteretailer = new System.Windows.Forms.Button();
            this.searchretailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorym
            // 
            this.categorym.AutoSize = true;
            this.categorym.BackColor = System.Drawing.Color.Black;
            this.categorym.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorym.ForeColor = System.Drawing.Color.White;
            this.categorym.Location = new System.Drawing.Point(362, 35);
            this.categorym.Name = "categorym";
            this.categorym.Size = new System.Drawing.Size(195, 62);
            this.categorym.TabIndex = 14;
            this.categorym.Text = "Retailer";
            // 
            // Adddistributor
            // 
            this.Adddistributor.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adddistributor.ForeColor = System.Drawing.Color.Black;
            this.Adddistributor.Location = new System.Drawing.Point(72, 112);
            this.Adddistributor.Name = "Adddistributor";
            this.Adddistributor.Size = new System.Drawing.Size(143, 37);
            this.Adddistributor.TabIndex = 15;
            this.Adddistributor.Text = "Add Retailer";
            this.Adddistributor.UseVisualStyleBackColor = true;
            this.Adddistributor.Click += new System.EventHandler(this.Adddistributor_Click);
            // 
            // updateretailer
            // 
            this.updateretailer.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateretailer.ForeColor = System.Drawing.Color.Black;
            this.updateretailer.Location = new System.Drawing.Point(475, 112);
            this.updateretailer.Name = "updateretailer";
            this.updateretailer.Size = new System.Drawing.Size(192, 37);
            this.updateretailer.TabIndex = 16;
            this.updateretailer.Text = "Update Retailer";
            this.updateretailer.UseVisualStyleBackColor = true;
            this.updateretailer.Click += new System.EventHandler(this.updateretailer_Click);
            // 
            // deleteretailer
            // 
            this.deleteretailer.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteretailer.ForeColor = System.Drawing.Color.Black;
            this.deleteretailer.Location = new System.Drawing.Point(699, 112);
            this.deleteretailer.Name = "deleteretailer";
            this.deleteretailer.Size = new System.Drawing.Size(170, 37);
            this.deleteretailer.TabIndex = 17;
            this.deleteretailer.Text = "Delete Retailer";
            this.deleteretailer.UseVisualStyleBackColor = true;
            this.deleteretailer.Click += new System.EventHandler(this.deleteretailer_Click);
            // 
            // searchretailer
            // 
            this.searchretailer.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchretailer.ForeColor = System.Drawing.Color.Black;
            this.searchretailer.Location = new System.Drawing.Point(244, 112);
            this.searchretailer.Name = "searchretailer";
            this.searchretailer.Size = new System.Drawing.Size(190, 37);
            this.searchretailer.TabIndex = 18;
            this.searchretailer.Text = "Search Retailer";
            this.searchretailer.UseVisualStyleBackColor = true;
            this.searchretailer.Click += new System.EventHandler(this.searchdistributor_Click);
            // 
            // retailerheader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(916, 183);
            this.Controls.Add(this.searchretailer);
            this.Controls.Add(this.deleteretailer);
            this.Controls.Add(this.updateretailer);
            this.Controls.Add(this.Adddistributor);
            this.Controls.Add(this.categorym);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "retailerheader";
            this.Text = "retailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categorym;
        private System.Windows.Forms.Button Adddistributor;
        private System.Windows.Forms.Button updateretailer;
        private System.Windows.Forms.Button deleteretailer;
        private System.Windows.Forms.Button searchretailer;
    }
}