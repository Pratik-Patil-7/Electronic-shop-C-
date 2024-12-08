namespace Wholesale_electronic_shop
{
    partial class deleteretailer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.retailer_id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.lbl_Distributor_Id);
            this.panel1.Controls.Add(this.retailer_id);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 69);
            this.panel1.TabIndex = 159;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(747, 10);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(154, 48);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(39, 18);
            this.lbl_Distributor_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(126, 31);
            this.lbl_Distributor_Id.TabIndex = 1;
            this.lbl_Distributor_Id.Text = "Retailer ID";
            // 
            // retailer_id
            // 
            this.retailer_id.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailer_id.Location = new System.Drawing.Point(244, 11);
            this.retailer_id.Margin = new System.Windows.Forms.Padding(4);
            this.retailer_id.MaxLength = 10;
            this.retailer_id.Name = "retailer_id";
            this.retailer_id.Size = new System.Drawing.Size(275, 42);
            this.retailer_id.TabIndex = 2;
            this.retailer_id.TextChanged += new System.EventHandler(this.product_id_TextChanged);
            this.retailer_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_id_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(565, 10);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 49);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SpringGreen;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 341);
            this.dataGridView1.TabIndex = 160;
            // 
            // deleteretailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1080, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteretailer";
            this.Text = "deleteretailer";
            this.Load += new System.EventHandler(this.deleteretailer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Distributor_Id;
        private System.Windows.Forms.TextBox retailer_id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}