namespace quanlynhahang
{
    partial class Menu2
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
            this.flptable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnin = new System.Windows.Forms.Button();
            this.cbbban = new System.Windows.Forms.ComboBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.nugiamgia = new System.Windows.Forms.NumericUpDown();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.btnchuyenban = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.cbbmon = new System.Windows.Forms.ComboBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.nudsoluong = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nugiamgia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flptable
            // 
            this.flptable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flptable.AutoScroll = true;
            this.flptable.Location = new System.Drawing.Point(0, 0);
            this.flptable.Name = "flptable";
            this.flptable.Size = new System.Drawing.Size(446, 450);
            this.flptable.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnin);
            this.panel4.Controls.Add(this.cbbban);
            this.panel4.Controls.Add(this.btnthanhtoan);
            this.panel4.Controls.Add(this.nugiamgia);
            this.panel4.Controls.Add(this.btngiamgia);
            this.panel4.Controls.Add(this.btnchuyenban);
            this.panel4.Location = new System.Drawing.Point(3, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 64);
            this.panel4.TabIndex = 14;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(245, 32);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(85, 23);
            this.btnin.TabIndex = 6;
            this.btnin.Text = "In Hóa Đơn";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // cbbban
            // 
            this.cbbban.FormattingEnabled = true;
            this.cbbban.Location = new System.Drawing.Point(8, 32);
            this.cbbban.Name = "cbbban";
            this.cbbban.Size = new System.Drawing.Size(93, 21);
            this.cbbban.TabIndex = 5;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(243, 3);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(87, 29);
            this.btnthanhtoan.TabIndex = 4;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // nugiamgia
            // 
            this.nugiamgia.Location = new System.Drawing.Point(139, 32);
            this.nugiamgia.Name = "nugiamgia";
            this.nugiamgia.Size = new System.Drawing.Size(93, 20);
            this.nugiamgia.TabIndex = 3;
            this.nugiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btngiamgia
            // 
            this.btngiamgia.Location = new System.Drawing.Point(139, 3);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(93, 29);
            this.btngiamgia.TabIndex = 2;
            this.btngiamgia.Text = "Giảm Giá";
            this.btngiamgia.UseVisualStyleBackColor = true;
            // 
            // btnchuyenban
            // 
            this.btnchuyenban.Location = new System.Drawing.Point(8, 3);
            this.btnchuyenban.Name = "btnchuyenban";
            this.btnchuyenban.Size = new System.Drawing.Size(93, 29);
            this.btnchuyenban.TabIndex = 0;
            this.btnchuyenban.Text = "Chuyển Bàn";
            this.btnchuyenban.UseVisualStyleBackColor = true;
            this.btnchuyenban.Click += new System.EventHandler(this.btnchuyenban_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txttongtien);
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 314);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.ForeColor = System.Drawing.Color.Red;
            this.txttongtien.Location = new System.Drawing.Point(230, 235);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(100, 24);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.Text = "0";
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(8, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(334, 232);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 74;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnthemmon);
            this.panel3.Controls.Add(this.cbbmon);
            this.panel3.Controls.Add(this.cbbloai);
            this.panel3.Controls.Add(this.nudsoluong);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 60);
            this.panel3.TabIndex = 16;
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(220, 30);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(110, 23);
            this.btnthemmon.TabIndex = 3;
            this.btnthemmon.Text = "Thêm Món";
            this.btnthemmon.UseVisualStyleBackColor = true;
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // cbbmon
            // 
            this.cbbmon.FormattingEnabled = true;
            this.cbbmon.Location = new System.Drawing.Point(8, 30);
            this.cbbmon.Name = "cbbmon";
            this.cbbmon.Size = new System.Drawing.Size(206, 21);
            this.cbbmon.TabIndex = 2;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(8, 3);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(206, 21);
            this.cbbloai.TabIndex = 1;
            this.cbbloai.SelectedIndexChanged += new System.EventHandler(this.cbbloai_SelectedIndexChanged);
            // 
            // nudsoluong
            // 
            this.nudsoluong.Location = new System.Drawing.Point(220, 3);
            this.nudsoluong.Name = "nudsoluong";
            this.nudsoluong.Size = new System.Drawing.Size(110, 20);
            this.nudsoluong.TabIndex = 0;
            this.nudsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(452, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 450);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Bàn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flptable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu2";
            this.Text = "Menu2";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nugiamgia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flptable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbban;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.NumericUpDown nugiamgia;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.Button btnchuyenban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.ComboBox cbbmon;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.NumericUpDown nudsoluong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button button1;
    }
}