namespace Wholesale_electronic_shop
{
    partial class updateretailer
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
            this.gstin = new System.Windows.Forms.TextBox();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.tb_Alternate_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.retailer_name = new System.Windows.Forms.TextBox();
            this.lbl_Alternate_No = new System.Windows.Forms.Label();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.retailer_id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gstin
            // 
            this.gstin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gstin.BackColor = System.Drawing.Color.White;
            this.gstin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstin.Location = new System.Drawing.Point(727, 287);
            this.gstin.Margin = new System.Windows.Forms.Padding(4);
            this.gstin.MaxLength = 12;
            this.gstin.Name = "gstin";
            this.gstin.Size = new System.Drawing.Size(275, 34);
            this.gstin.TabIndex = 150;
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhar_No.ForeColor = System.Drawing.Color.White;
            this.lbl_Adhar_No.Location = new System.Drawing.Point(550, 294);
            this.lbl_Adhar_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(105, 28);
            this.lbl_Adhar_No.TabIndex = 151;
            this.lbl_Adhar_No.Text = "GSTIN No";
            // 
            // tb_Alternate_No
            // 
            this.tb_Alternate_No.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_No.Location = new System.Drawing.Point(727, 210);
            this.tb_Alternate_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Alternate_No.MaxLength = 10;
            this.tb_Alternate_No.Name = "tb_Alternate_No";
            this.tb_Alternate_No.Size = new System.Drawing.Size(275, 34);
            this.tb_Alternate_No.TabIndex = 142;
            this.tb_Alternate_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Alternate_No_KeyPress);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(727, 131);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(275, 34);
            this.tb_Mobile_No.TabIndex = 141;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(198, 315);
            this.tb_Email_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email_Id.MaxLength = 20;
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(275, 34);
            this.tb_Email_Id.TabIndex = 140;
            this.tb_Email_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Email_Id_KeyPress);
            this.tb_Email_Id.Leave += new System.EventHandler(this.tb_Email_Id_Leave);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(198, 203);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(275, 90);
            this.tb_Address.TabIndex = 139;
            // 
            // retailer_name
            // 
            this.retailer_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailer_name.Location = new System.Drawing.Point(198, 139);
            this.retailer_name.Margin = new System.Windows.Forms.Padding(4);
            this.retailer_name.MaxLength = 40;
            this.retailer_name.Name = "retailer_name";
            this.retailer_name.Size = new System.Drawing.Size(275, 34);
            this.retailer_name.TabIndex = 138;
            this.retailer_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.retailer_name_KeyPress);
            // 
            // lbl_Alternate_No
            // 
            this.lbl_Alternate_No.AutoSize = true;
            this.lbl_Alternate_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternate_No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_No.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternate_No.Location = new System.Drawing.Point(550, 217);
            this.lbl_Alternate_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alternate_No.Name = "lbl_Alternate_No";
            this.lbl_Alternate_No.Size = new System.Drawing.Size(135, 28);
            this.lbl_Alternate_No.TabIndex = 147;
            this.lbl_Alternate_No.Text = "Alternate No";
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.AutoSize = true;
            this.lbl_Email_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Email_Id.Location = new System.Drawing.Point(13, 322);
            this.lbl_Email_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(88, 28);
            this.lbl_Email_Id.TabIndex = 145;
            this.lbl_Email_Id.Text = "Email Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.lbl_Distributor_Id);
            this.panel1.Controls.Add(this.retailer_id);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(28, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 69);
            this.panel1.TabIndex = 144;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(747, 10);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 48);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(36, 18);
            this.lbl_Distributor_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(126, 31);
            this.lbl_Distributor_Id.TabIndex = 1;
            this.lbl_Distributor_Id.Text = "Retailer ID";
            // 
            // retailer_id
            // 
            this.retailer_id.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailer_id.Location = new System.Drawing.Point(202, 13);
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
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(12, 139);
            this.lbl_Distributor_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(148, 28);
            this.lbl_Distributor_Name.TabIndex = 143;
            this.lbl_Distributor_Name.Text = "Retailer Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.White;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(554, 138);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(112, 28);
            this.lbl_Mobile_No.TabIndex = 146;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.White;
            this.lbl_Address.Location = new System.Drawing.Point(13, 224);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(87, 28);
            this.lbl_Address.TabIndex = 152;
            this.lbl_Address.Text = "Address";
            // 
            // updateretailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1028, 381);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.gstin);
            this.Controls.Add(this.lbl_Adhar_No);
            this.Controls.Add(this.tb_Alternate_No);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Email_Id);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.retailer_name);
            this.Controls.Add(this.lbl_Alternate_No);
            this.Controls.Add(this.lbl_Email_Id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Distributor_Name);
            this.Controls.Add(this.lbl_Mobile_No);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateretailer";
            this.Text = "updateretailer";
            this.Load += new System.EventHandler(this.updateretailer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gstin;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.TextBox tb_Alternate_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox retailer_name;
        private System.Windows.Forms.Label lbl_Alternate_No;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Distributor_Id;
        private System.Windows.Forms.TextBox retailer_id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Address;
    }
}