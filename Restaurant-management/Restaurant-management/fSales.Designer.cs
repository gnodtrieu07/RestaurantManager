namespace Restaurant_management
{
    partial class fSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSales));
            this.panel3 = new System.Windows.Forms.Panel();
            this.datetimeFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datetimeToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWatchView = new System.Windows.Forms.Button();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datetimeFromDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(9, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 37);
            this.panel3.TabIndex = 6;
            // 
            // datetimeFromDate
            // 
            this.datetimeFromDate.Location = new System.Drawing.Point(96, 10);
            this.datetimeFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeFromDate.Name = "datetimeFromDate";
            this.datetimeFromDate.Size = new System.Drawing.Size(269, 20);
            this.datetimeFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datetimeToDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(9, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 37);
            this.panel4.TabIndex = 7;
            // 
            // datetimeToDate
            // 
            this.datetimeToDate.Location = new System.Drawing.Point(96, 10);
            this.datetimeToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeToDate.Name = "datetimeToDate";
            this.datetimeToDate.Size = new System.Drawing.Size(269, 20);
            this.datetimeToDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày kết thúc: ";
            // 
            // btnWatchView
            // 
            this.btnWatchView.ForeColor = System.Drawing.Color.Black;
            this.btnWatchView.Image = ((System.Drawing.Image)(resources.GetObject("btnWatchView.Image")));
            this.btnWatchView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatchView.Location = new System.Drawing.Point(462, 46);
            this.btnWatchView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatchView.Name = "btnWatchView";
            this.btnWatchView.Size = new System.Drawing.Size(101, 36);
            this.btnWatchView.TabIndex = 9;
            this.btnWatchView.Text = " Xem";
            this.btnWatchView.UseVisualStyleBackColor = true;
            this.btnWatchView.Click += new System.EventHandler(this.btnWatchView_Click);
            // 
            // dataBill
            // 
            this.dataBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBill.Location = new System.Drawing.Point(9, 122);
            this.dataBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBill.Name = "dataBill";
            this.dataBill.RowHeadersWidth = 51;
            this.dataBill.RowTemplate.Height = 24;
            this.dataBill.Size = new System.Drawing.Size(670, 399);
            this.dataBill.TabIndex = 10;
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
            this.btnExit.TabIndex = 24;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(690, 537);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataBill);
            this.Controls.Add(this.btnWatchView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(706, 576);
            this.Name = "fSales";
            this.Text = "Chương trình Giảm giá";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker datetimeFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker datetimeToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWatchView;
        private System.Windows.Forms.DataGridView dataBill;
        private System.Windows.Forms.Button btnExit;
    }
}