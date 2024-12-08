namespace Wholesale_electronic_shop
{
    partial class addcategoryitem
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
            this.Category_Name = new System.Windows.Forms.TextBox();
            this.Category_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Category_Name
            // 
            this.Category_Name.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.Location = new System.Drawing.Point(423, 237);
            this.Category_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Category_Name.MaxLength = 40;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(277, 39);
            this.Category_Name.TabIndex = 35;
            this.Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Category_Name_KeyPress);
            this.Category_Name.Leave += new System.EventHandler(this.Category_Name_Leave);
            // 
            // Category_Id
            // 
            this.Category_Id.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Id.Location = new System.Drawing.Point(423, 145);
            this.Category_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Category_Id.MaxLength = 5;
            this.Category_Id.Name = "Category_Id";
            this.Category_Id.Size = new System.Drawing.Size(277, 39);
            this.Category_Id.TabIndex = 34;
            this.Category_Id.TextChanged += new System.EventHandler(this.Category_Id_TextChanged);
            this.Category_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Category_Id_KeyPress);
            this.Category_Id.Leave += new System.EventHandler(this.Category_Id_Leave);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Category_Name.Location = new System.Drawing.Point(178, 235);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(222, 38);
            this.lbl_Category_Name.TabIndex = 37;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Category_Id
            // 
            this.lbl_Category_Id.AutoSize = true;
            this.lbl_Category_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Id.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Category_Id.Location = new System.Drawing.Point(188, 143);
            this.lbl_Category_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Id.Name = "lbl_Category_Id";
            this.lbl_Category_Id.Size = new System.Drawing.Size(170, 38);
            this.lbl_Category_Id.TabIndex = 36;
            this.lbl_Category_Id.Text = "Category Id";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(462, 314);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 59);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // addcategoryitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.Category_Id);
            this.Controls.Add(this.lbl_Category_Name);
            this.Controls.Add(this.lbl_Category_Id);
            this.Controls.Add(this.btn_Save);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcategoryitem";
            this.Text = "addcategoryitem";
            this.Load += new System.EventHandler(this.addcategoryitem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Category_Name;
        private System.Windows.Forms.TextBox Category_Id;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Id;
        private System.Windows.Forms.Button btn_Save;
    }
}