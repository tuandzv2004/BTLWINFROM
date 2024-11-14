namespace quanlynhahang
{
    partial class danhmuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dtpk1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk2 = new System.Windows.Forms.DateTimePicker();
            this.dtgtk = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthongke);
            this.panel1.Controls.Add(this.dtpk1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpk2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(560, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Location = new System.Drawing.Point(59, 197);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(129, 32);
            this.btnthongke.TabIndex = 3;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dtpk1
            // 
            this.dtpk1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk1.Location = new System.Drawing.Point(28, 12);
            this.dtpk1.Name = "dtpk1";
            this.dtpk1.Size = new System.Drawing.Size(200, 20);
            this.dtpk1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐẾN NGÀY";
            // 
            // dtpk2
            // 
            this.dtpk2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk2.Location = new System.Drawing.Point(28, 132);
            this.dtpk2.Name = "dtpk2";
            this.dtpk2.Size = new System.Drawing.Size(200, 20);
            this.dtpk2.TabIndex = 1;
            // 
            // dtgtk
            // 
            this.dtgtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgtk.Location = new System.Drawing.Point(0, 0);
            this.dtgtk.Name = "dtgtk";
            this.dtgtk.Size = new System.Drawing.Size(560, 450);
            this.dtgtk.TabIndex = 1;
            this.dtgtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtk_CellContentClick);
            // 
            // danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgtk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "danhmuc";
            this.Text = "danhmuc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk2;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.DateTimePicker dtpk1;
        private System.Windows.Forms.DataGridView dtgtk;
    }
}