namespace Wholesale_electronic_shop
{
    partial class searchdistributor
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
            this.pnl_Search_Head = new System.Windows.Forms.Panel();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.distributor_id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Search_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Search_Head
            // 
            this.pnl_Search_Head.BackColor = System.Drawing.Color.Gray;
            this.pnl_Search_Head.Controls.Add(this.lbl_Distributor_Id);
            this.pnl_Search_Head.Controls.Add(this.distributor_id);
            this.pnl_Search_Head.Controls.Add(this.btn_Search);
            this.pnl_Search_Head.Location = new System.Drawing.Point(122, 13);
            this.pnl_Search_Head.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search_Head.Name = "pnl_Search_Head";
            this.pnl_Search_Head.Size = new System.Drawing.Size(793, 69);
            this.pnl_Search_Head.TabIndex = 57;
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(29, 14);
            this.lbl_Distributor_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(163, 31);
            this.lbl_Distributor_Id.TabIndex = 1;
            this.lbl_Distributor_Id.Text = "Distributor ID";
            // 
            // distributor_id
            // 
            this.distributor_id.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributor_id.Location = new System.Drawing.Point(262, 14);
            this.distributor_id.Margin = new System.Windows.Forms.Padding(4);
            this.distributor_id.MaxLength = 10;
            this.distributor_id.Name = "distributor_id";
            this.distributor_id.Size = new System.Drawing.Size(275, 42);
            this.distributor_id.TabIndex = 2;
            this.distributor_id.TextChanged += new System.EventHandler(this.product_id_TextChanged);
            this.distributor_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_id_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(565, 7);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(204, 49);
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
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 325);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // searchdistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1139, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_Search_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchdistributor";
            this.Text = "searchdistributor";
            this.Load += new System.EventHandler(this.searchdistributor_Load);
            this.pnl_Search_Head.ResumeLayout(false);
            this.pnl_Search_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Search_Head;
        private System.Windows.Forms.Label lbl_Distributor_Id;
        private System.Windows.Forms.TextBox distributor_id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}