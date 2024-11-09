namespace quanlynhahang
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.menubar = new System.Windows.Forms.FlowLayoutPanel();
            this.pn1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pn2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pn3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pn4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pn5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.menubar.SuspendLayout();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn3.SuspendLayout();
            this.pn4.SuspendLayout();
            this.pn5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 42);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(859, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÀ HÀNG";
            // 
            // btnmenu
            // 
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(3, 3);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(47, 36);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 1;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.LightGray;
            this.menubar.Controls.Add(this.pn1);
            this.menubar.Controls.Add(this.pn2);
            this.menubar.Controls.Add(this.pn3);
            this.menubar.Controls.Add(this.pn4);
            this.menubar.Controls.Add(this.pn5);
            this.menubar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menubar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menubar.Location = new System.Drawing.Point(0, 42);
            this.menubar.Name = "menubar";
            this.menubar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.menubar.Size = new System.Drawing.Size(200, 548);
            this.menubar.TabIndex = 1;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.button1);
            this.pn1.ForeColor = System.Drawing.Color.White;
            this.pn1.Location = new System.Drawing.Point(3, 33);
            this.pn1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(200, 58);
            this.pn1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-4, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "              Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.button2);
            this.pn2.ForeColor = System.Drawing.Color.White;
            this.pn2.Location = new System.Drawing.Point(3, 124);
            this.pn2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(200, 58);
            this.pn2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-4, -13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "              button1";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn3
            // 
            this.pn3.Controls.Add(this.button3);
            this.pn3.ForeColor = System.Drawing.Color.White;
            this.pn3.Location = new System.Drawing.Point(3, 215);
            this.pn3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(200, 58);
            this.pn3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-4, -9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "              button1";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pn4
            // 
            this.pn4.Controls.Add(this.button4);
            this.pn4.ForeColor = System.Drawing.Color.White;
            this.pn4.Location = new System.Drawing.Point(3, 306);
            this.pn4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(200, 58);
            this.pn4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-4, -9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 81);
            this.button4.TabIndex = 2;
            this.button4.Text = "              button1";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pn5
            // 
            this.pn5.Controls.Add(this.button5);
            this.pn5.ForeColor = System.Drawing.Color.White;
            this.pn5.Location = new System.Drawing.Point(3, 397);
            this.pn5.Name = "pn5";
            this.pn5.Size = new System.Drawing.Size(200, 58);
            this.pn5.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-4, -9);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 81);
            this.button5.TabIndex = 2;
            this.button5.Text = "              Đăng Xuất";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.Interval = 3;
            this.menu.Tick += new System.EventHandler(this.menu_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 590);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.menubar.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn3.ResumeLayout(false);
            this.pn4.ResumeLayout(false);
            this.pn5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel menubar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Timer menu;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pn5;
        private System.Windows.Forms.Button button5;
    }
}