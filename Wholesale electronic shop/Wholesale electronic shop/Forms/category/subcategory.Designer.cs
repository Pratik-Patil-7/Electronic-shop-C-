namespace Wholesale_electronic_shop
{
    partial class subcategory
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
            this.Category_Name = new System.Windows.Forms.ComboBox();
            this.subcategory_Name = new System.Windows.Forms.TextBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Category_Name
            // 
            this.Category_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.FormattingEnabled = true;
            this.Category_Name.Location = new System.Drawing.Point(480, 131);
            this.Category_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Category_Name.MaxLength = 40;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(277, 36);
            this.Category_Name.TabIndex = 32;
            // 
            // subcategory_Name
            // 
            this.subcategory_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcategory_Name.Location = new System.Drawing.Point(480, 220);
            this.subcategory_Name.Margin = new System.Windows.Forms.Padding(4);
            this.subcategory_Name.MaxLength = 40;
            this.subcategory_Name.Name = "subcategory_Name";
            this.subcategory_Name.Size = new System.Drawing.Size(277, 34);
            this.subcategory_Name.TabIndex = 34;
            this.subcategory_Name.TextChanged += new System.EventHandler(this.subcategory_Name_TextChanged);
            this.subcategory_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subcategory_Name_KeyPress);
            this.subcategory_Name.Leave += new System.EventHandler(this.subcategory_Name_Leave);
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(177, 221);
            this.lbl_Subcategory_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(218, 31);
            this.lbl_Subcategory_Name.TabIndex = 37;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Category_Name.Location = new System.Drawing.Point(177, 131);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(180, 31);
            this.lbl_Category_Name.TabIndex = 36;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(542, 297);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(138, 54);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // subcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(804, 498);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.subcategory_Name);
            this.Controls.Add(this.lbl_Subcategory_Name);
            this.Controls.Add(this.lbl_Category_Name);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "subcategory";
            this.Text = "subcategory";
            this.Load += new System.EventHandler(this.subcategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Category_Name;
        private System.Windows.Forms.TextBox subcategory_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Save;
    }
}