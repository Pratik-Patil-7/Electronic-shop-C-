namespace Wholesale_electronic_shop
{
    partial class distributorbill
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.distributor_name = new System.Windows.Forms.ComboBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.billno = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(653, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 74;
            this.label2.Text = "Bill Date ";
            // 
            // distributor_name
            // 
            this.distributor_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.distributor_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributor_name.FormattingEnabled = true;
            this.distributor_name.Location = new System.Drawing.Point(242, 44);
            this.distributor_name.Margin = new System.Windows.Forms.Padding(4);
            this.distributor_name.Name = "distributor_name";
            this.distributor_name.Size = new System.Drawing.Size(363, 36);
            this.distributor_name.TabIndex = 72;
            this.distributor_name.SelectedIndexChanged += new System.EventHandler(this.distributor_name_SelectedIndexChanged);
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(13, 48);
            this.lbl_Customer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(194, 30);
            this.lbl_Customer_ID.TabIndex = 71;
            this.lbl_Customer_ID.Text = "Distributor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(676, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 113;
            this.label3.Text = "Bill No";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(433, 92);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 41);
            this.search.TabIndex = 114;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(278, 92);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(124, 41);
            this.btn_Refresh.TabIndex = 115;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(697, 592);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 117;
            this.label1.Text = "Amount :";
            // 
            // totalamount
            // 
            this.totalamount.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.Location = new System.Drawing.Point(831, 592);
            this.totalamount.Margin = new System.Windows.Forms.Padding(4);
            this.totalamount.MaxLength = 80;
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(150, 39);
            this.totalamount.TabIndex = 116;
            this.totalamount.TextChanged += new System.EventHandler(this.totalamount_TextChanged);
            // 
            // billno
            // 
            this.billno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.billno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billno.FormattingEnabled = true;
            this.billno.Location = new System.Drawing.Point(772, 92);
            this.billno.Margin = new System.Windows.Forms.Padding(4);
            this.billno.Name = "billno";
            this.billno.Size = new System.Drawing.Size(131, 36);
            this.billno.TabIndex = 118;
            this.billno.SelectedIndexChanged += new System.EventHandler(this.billno_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(779, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 119;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // distributorbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1046, 648);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.billno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distributor_name);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "distributorbill";
            this.Text = "distributorbill";
            this.Load += new System.EventHandler(this.distributorbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox distributor_name;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.ComboBox billno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}