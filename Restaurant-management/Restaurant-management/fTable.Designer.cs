namespace Restaurant_management
{
    partial class fTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTable));
            this.label8 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.texboxTableID = new System.Windows.Forms.TextBox();
            this.comboBoxTableStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textboxTableName = new System.Windows.Forms.TextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.brnWatchTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.brnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID bàn";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel21.Controls.Add(this.label8);
            this.panel21.Controls.Add(this.texboxTableID);
            this.panel21.Location = new System.Drawing.Point(2, 15);
            this.panel21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(296, 52);
            this.panel21.TabIndex = 8;
            // 
            // texboxTableID
            // 
            this.texboxTableID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texboxTableID.Location = new System.Drawing.Point(107, 15);
            this.texboxTableID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.texboxTableID.Name = "texboxTableID";
            this.texboxTableID.ReadOnly = true;
            this.texboxTableID.Size = new System.Drawing.Size(186, 24);
            this.texboxTableID.TabIndex = 1;
            // 
            // comboBoxTableStatus
            // 
            this.comboBoxTableStatus.FormattingEnabled = true;
            this.comboBoxTableStatus.Location = new System.Drawing.Point(105, 14);
            this.comboBoxTableStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTableStatus.Name = "comboBoxTableStatus";
            this.comboBoxTableStatus.Size = new System.Drawing.Size(188, 21);
            this.comboBoxTableStatus.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Trạng thái bàn";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel22.Controls.Add(this.comboBoxTableStatus);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Location = new System.Drawing.Point(337, 47);
            this.panel22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(296, 52);
            this.panel22.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên bàn";
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.Controls.Add(this.panel20);
            this.panel16.Controls.Add(this.panel22);
            this.panel16.Controls.Add(this.panel21);
            this.panel16.Location = new System.Drawing.Point(9, 383);
            this.panel16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(670, 138);
            this.panel16.TabIndex = 19;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel20.Controls.Add(this.label7);
            this.panel20.Controls.Add(this.textboxTableName);
            this.panel20.Location = new System.Drawing.Point(2, 86);
            this.panel20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(296, 52);
            this.panel20.TabIndex = 9;
            // 
            // textboxTableName
            // 
            this.textboxTableName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTableName.Location = new System.Drawing.Point(105, 15);
            this.textboxTableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxTableName.Name = "textboxTableName";
            this.textboxTableName.Size = new System.Drawing.Size(186, 24);
            this.textboxTableName.TabIndex = 1;
            // 
            // dataTable
            // 
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(9, 87);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(670, 291);
            this.dataTable.TabIndex = 18;
            // 
            // brnWatchTable
            // 
            this.brnWatchTable.ForeColor = System.Drawing.Color.Black;
            this.brnWatchTable.Location = new System.Drawing.Point(374, 5);
            this.brnWatchTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnWatchTable.Name = "brnWatchTable";
            this.brnWatchTable.Size = new System.Drawing.Size(80, 43);
            this.brnWatchTable.TabIndex = 7;
            this.brnWatchTable.Text = "Xem";
            this.brnWatchTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.Color.Gold;
            this.btnEditTable.ForeColor = System.Drawing.Color.Black;
            this.btnEditTable.Location = new System.Drawing.Point(245, 5);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(80, 43);
            this.btnEditTable.TabIndex = 6;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = false;
            // 
            // brnEditTable
            // 
            this.brnEditTable.BackColor = System.Drawing.Color.OrangeRed;
            this.brnEditTable.ForeColor = System.Drawing.Color.Black;
            this.brnEditTable.Location = new System.Drawing.Point(124, 5);
            this.brnEditTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnEditTable.Name = "brnEditTable";
            this.brnEditTable.Size = new System.Drawing.Size(80, 43);
            this.brnEditTable.TabIndex = 5;
            this.brnEditTable.Text = "Xóa";
            this.brnEditTable.UseVisualStyleBackColor = false;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTable.Location = new System.Drawing.Point(0, 5);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(80, 43);
            this.btnAddTable.TabIndex = 4;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.brnWatchTable);
            this.panel15.Controls.Add(this.btnEditTable);
            this.panel15.Controls.Add(this.brnEditTable);
            this.panel15.Controls.Add(this.btnAddTable);
            this.panel15.Location = new System.Drawing.Point(9, 30);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(511, 52);
            this.panel15.TabIndex = 17;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(690, 537);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.panel15);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(706, 576);
            this.Name = "fTable";
            this.Text = "Quản Lý Bàn";
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox texboxTableID;
        private System.Windows.Forms.ComboBox comboBoxTableStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox textboxTableName;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button brnWatchTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button brnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnExit;
    }
}