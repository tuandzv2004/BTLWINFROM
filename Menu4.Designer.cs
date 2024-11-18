namespace quanlynhahang
{
    partial class Menu4
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgaccc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.txttenht = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtloaitk = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgaccc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgaccc);
            this.panel2.Controls.Add(this.txtloaitk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 450);
            this.panel2.TabIndex = 4;
            // 
            // dtgaccc
            // 
            this.dtgaccc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgaccc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgaccc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgaccc.Location = new System.Drawing.Point(0, 0);
            this.dtgaccc.Name = "dtgaccc";
            this.dtgaccc.Size = new System.Drawing.Size(456, 450);
            this.dtgaccc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên hiển thị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên tài khoản: ";
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(200, 383);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(132, 55);
            this.btnxem.TabIndex = 8;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(18, 383);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(132, 55);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(200, 310);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(132, 55);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(18, 310);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(132, 55);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttentk
            // 
            this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentk.Location = new System.Drawing.Point(144, 12);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(188, 26);
            this.txttentk.TabIndex = 1;
            // 
            // txttenht
            // 
            this.txttenht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenht.Location = new System.Drawing.Point(144, 68);
            this.txttenht.Name = "txttenht";
            this.txttenht.Size = new System.Drawing.Size(188, 26);
            this.txttenht.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbloai);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.txttentk);
            this.panel1.Controls.Add(this.txttenht);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(456, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 450);
            this.panel1.TabIndex = 3;
            // 
            // txtloaitk
            // 
            this.txtloaitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloaitk.HideSelection = false;
            this.txtloaitk.Location = new System.Drawing.Point(136, 163);
            this.txtloaitk.Name = "txtloaitk";
            this.txtloaitk.Size = new System.Drawing.Size(188, 26);
            this.txtloaitk.TabIndex = 13;
            this.txtloaitk.TextChanged += new System.EventHandler(this.txtloaitk_TextChanged);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(18, 208);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(314, 55);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Đặt lại mật khẩu";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cbbloai
            // 
            this.cbbloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(144, 114);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(188, 28);
            this.cbbloai.TabIndex = 14;
            // 
            // Menu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu4";
            this.Text = "Menu4";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgaccc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgaccc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.TextBox txttenht;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtloaitk;
        private System.Windows.Forms.ComboBox cbbloai;
    }
}