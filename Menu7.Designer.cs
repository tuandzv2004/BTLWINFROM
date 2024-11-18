namespace quanlynhahang
{
    partial class Menu7
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
            this.dtgban = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttenban = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.cbbtrangthai = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgban)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgban);
            this.panel2.Controls.Add(this.txttrangthai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 450);
            this.panel2.TabIndex = 4;
            // 
            // dtgban
            // 
            this.dtgban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgban.Location = new System.Drawing.Point(0, 0);
            this.dtgban.Name = "dtgban";
            this.dtgban.Size = new System.Drawing.Size(456, 450);
            this.dtgban.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID: ";
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
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(144, 64);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(188, 26);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txttenban
            // 
            this.txttenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenban.Location = new System.Drawing.Point(144, 122);
            this.txttenban.Name = "txttenban";
            this.txttenban.Size = new System.Drawing.Size(188, 26);
            this.txttenban.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbtrangthai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txttenban);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(456, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 450);
            this.panel1.TabIndex = 3;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrangthai.Location = new System.Drawing.Point(142, 212);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(188, 26);
            this.txttrangthai.TabIndex = 12;
            this.txttrangthai.TextChanged += new System.EventHandler(this.txttrangthai_TextChanged);
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.Location = new System.Drawing.Point(144, 180);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.Size = new System.Drawing.Size(188, 28);
            this.cbbtrangthai.TabIndex = 13;
            // 
            // Menu7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu7";
            this.Text = "Menu7";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgban)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttenban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.ComboBox cbbtrangthai;
    }
}