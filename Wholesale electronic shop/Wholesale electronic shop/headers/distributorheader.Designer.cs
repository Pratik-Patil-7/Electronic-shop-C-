namespace Wholesale_electronic_shop
{
    partial class distributorheader
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
            this.searchdistributor = new System.Windows.Forms.Button();
            this.deletedistributor = new System.Windows.Forms.Button();
            this.updatedistributor = new System.Windows.Forms.Button();
            this.Adddistributor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorym
            // 
            this.categorym.AutoSize = true;
            this.categorym.BackColor = System.Drawing.Color.Black;
            this.categorym.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorym.ForeColor = System.Drawing.Color.White;
            this.categorym.Location = new System.Drawing.Point(349, 32);
            this.categorym.Name = "categorym";
            this.categorym.Size = new System.Drawing.Size(269, 62);
            this.categorym.TabIndex = 9;
            this.categorym.Text = "Distributor";
            // 
            // searchdistributor
            // 
            this.searchdistributor.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdistributor.ForeColor = System.Drawing.Color.Black;
            this.searchdistributor.Location = new System.Drawing.Point(270, 111);
            this.searchdistributor.Name = "searchdistributor";
            this.searchdistributor.Size = new System.Drawing.Size(190, 37);
            this.searchdistributor.TabIndex = 13;
            this.searchdistributor.Text = "Search Distributor";
            this.searchdistributor.UseVisualStyleBackColor = true;
            this.searchdistributor.Click += new System.EventHandler(this.searchdistributor_Click);
            // 
            // deletedistributor
            // 
            this.deletedistributor.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedistributor.ForeColor = System.Drawing.Color.Black;
            this.deletedistributor.Location = new System.Drawing.Point(725, 111);
            this.deletedistributor.Name = "deletedistributor";
            this.deletedistributor.Size = new System.Drawing.Size(170, 37);
            this.deletedistributor.TabIndex = 12;
            this.deletedistributor.Text = "Delete Distributor";
            this.deletedistributor.UseVisualStyleBackColor = true;
            this.deletedistributor.Click += new System.EventHandler(this.deletedistributor_Click);
            // 
            // updatedistributor
            // 
            this.updatedistributor.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedistributor.ForeColor = System.Drawing.Color.Black;
            this.updatedistributor.Location = new System.Drawing.Point(501, 111);
            this.updatedistributor.Name = "updatedistributor";
            this.updatedistributor.Size = new System.Drawing.Size(192, 37);
            this.updatedistributor.TabIndex = 11;
            this.updatedistributor.Text = "Update Distributor";
            this.updatedistributor.UseVisualStyleBackColor = true;
            this.updatedistributor.Click += new System.EventHandler(this.updatedistributor_Click);
            // 
            // Adddistributor
            // 
            this.Adddistributor.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adddistributor.ForeColor = System.Drawing.Color.Black;
            this.Adddistributor.Location = new System.Drawing.Point(74, 111);
            this.Adddistributor.Name = "Adddistributor";
            this.Adddistributor.Size = new System.Drawing.Size(156, 37);
            this.Adddistributor.TabIndex = 10;
            this.Adddistributor.Text = "Add Distributor";
            this.Adddistributor.UseVisualStyleBackColor = true;
            this.Adddistributor.Click += new System.EventHandler(this.Adddistributor_Click);
            // 
            // distributorheader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(921, 168);
            this.Controls.Add(this.searchdistributor);
            this.Controls.Add(this.deletedistributor);
            this.Controls.Add(this.updatedistributor);
            this.Controls.Add(this.Adddistributor);
            this.Controls.Add(this.categorym);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "distributorheader";
            this.Text = "distributorheader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorym;
        private System.Windows.Forms.Button searchdistributor;
        private System.Windows.Forms.Button deletedistributor;
        private System.Windows.Forms.Button updatedistributor;
        private System.Windows.Forms.Button Adddistributor;
    }
}