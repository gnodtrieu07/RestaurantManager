namespace Restaurant_management
{
    partial class fFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFood));
            this.numericUpDownPriceFood = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxFoodID = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBoxCategoryFood = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxFoodName = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnWatchFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataFood = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceFood)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownPriceFood
            // 
            this.numericUpDownPriceFood.Location = new System.Drawing.Point(81, 17);
            this.numericUpDownPriceFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPriceFood.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownPriceFood.Name = "numericUpDownPriceFood";
            this.numericUpDownPriceFood.Size = new System.Drawing.Size(211, 20);
            this.numericUpDownPriceFood.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel12.Controls.Add(this.numericUpDownPriceFood);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(370, 390);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(296, 52);
            this.panel12.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID thức ăn";
            // 
            // textboxFoodID
            // 
            this.textboxFoodID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFoodID.Location = new System.Drawing.Point(81, 15);
            this.textboxFoodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxFoodID.Name = "textboxFoodID";
            this.textboxFoodID.ReadOnly = true;
            this.textboxFoodID.Size = new System.Drawing.Size(212, 24);
            this.textboxFoodID.TabIndex = 1;
            this.textboxFoodID.TextChanged += new System.EventHandler(this.textboxFoodID_TextChanged);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel10.Controls.Add(this.comboBoxCategoryFood);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(370, 469);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(296, 52);
            this.panel10.TabIndex = 13;
            // 
            // comboBoxCategoryFood
            // 
            this.comboBoxCategoryFood.FormattingEnabled = true;
            this.comboBoxCategoryFood.Location = new System.Drawing.Point(81, 14);
            this.comboBoxCategoryFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategoryFood.Name = "comboBoxCategoryFood";
            this.comboBoxCategoryFood.Size = new System.Drawing.Size(212, 21);
            this.comboBoxCategoryFood.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên món";
            // 
            // textboxFoodName
            // 
            this.textboxFoodName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFoodName.Location = new System.Drawing.Point(79, 15);
            this.textboxFoodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxFoodName.Name = "textboxFoodName";
            this.textboxFoodName.Size = new System.Drawing.Size(212, 24);
            this.textboxFoodName.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.textboxFoodName);
            this.panel11.Location = new System.Drawing.Point(9, 469);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(296, 52);
            this.panel11.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.textboxFoodID);
            this.panel9.Location = new System.Drawing.Point(9, 390);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(296, 52);
            this.panel9.TabIndex = 10;
            // 
            // btnWatchFood
            // 
            this.btnWatchFood.ForeColor = System.Drawing.Color.Black;
            this.btnWatchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnWatchFood.Image")));
            this.btnWatchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatchFood.Location = new System.Drawing.Point(500, 8);
            this.btnWatchFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatchFood.Name = "btnWatchFood";
            this.btnWatchFood.Size = new System.Drawing.Size(80, 43);
            this.btnWatchFood.TabIndex = 7;
            this.btnWatchFood.Text = "  Xem";
            this.btnWatchFood.UseVisualStyleBackColor = true;
            this.btnWatchFood.Click += new System.EventHandler(this.btnWatchFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.Yellow;
            this.btnEditFood.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEditFood.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFood.Image")));
            this.btnEditFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFood.Location = new System.Drawing.Point(334, 8);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(80, 43);
            this.btnEditFood.TabIndex = 6;
            this.btnEditFood.Text = " Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteFood.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFood.Image")));
            this.btnDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFood.Location = new System.Drawing.Point(166, 8);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(80, 43);
            this.btnDeleteFood.TabIndex = 5;
            this.btnDeleteFood.Text = "  Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddFood.ForeColor = System.Drawing.Color.Black;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(2, 8);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(80, 43);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "   Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnWatchFood);
            this.panel5.Controls.Add(this.btnEditFood);
            this.panel5.Controls.Add(this.btnDeleteFood);
            this.panel5.Controls.Add(this.btnAddFood);
            this.panel5.Location = new System.Drawing.Point(9, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 52);
            this.panel5.TabIndex = 9;
            // 
            // dataFood
            // 
            this.dataFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFood.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFood.Location = new System.Drawing.Point(0, 0);
            this.dataFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataFood.Name = "dataFood";
            this.dataFood.RowHeadersWidth = 51;
            this.dataFood.RowTemplate.Height = 24;
            this.dataFood.Size = new System.Drawing.Size(670, 262);
            this.dataFood.TabIndex = 0;
            this.dataFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFood_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.dataFood);
            this.panel6.Location = new System.Drawing.Point(9, 99);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(670, 262);
            this.panel6.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(633, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(690, 537);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(706, 576);
            this.Name = "fFood";
            this.Text = "fFood";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceFood)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownPriceFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxFoodID;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboBoxCategoryFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxFoodName;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnWatchFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
    }
}