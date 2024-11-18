using quanlynhahang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhahang
{
    public partial class Home : Form
    {
        Menu2 mn2;
        Menu3 mn3;
        Menu4 mn4;
        Menu5 mn5;
        danhmuc dm;
        Menu6 mn6;
        Menu7 mn7;

        private Account login;

        public Account Login
        {
            get { return login; }
            set { login = value; doiacc(login.Type); }
        }

        public Home(Account login)
        {
            InitializeComponent();
            this.Login = login;
            pnbar.Height = 62;
        }
        void doiacc(int type)
        {
            button2.Enabled= type ==1;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            menu.Start();
        }

        bool menu1 = true;  

        private void menu_Tick(object sender, EventArgs e)
        {
            if (menu1)
            {
                menubar.Width -= 30;
                if (menubar.Width <= 50)
                {
                    menu.Stop();
                    menu1 = false;
                    //pn1.Width = menubar.Width+5;
                    //pn2.Width = menubar.Width + 5;
                    //pn3.Width = menubar.Width + 5;
                    //pn4.Width = menubar.Width + 5;
                    //pn5.Width = menubar.Width + 5;
                }
            }
            else
            {
                menubar.Width += 30;
                if (menubar.Width >= 200)
                {
                    menu.Stop();
                    menu1 = true;
                    pn1.Width = menubar.Width + 1;
                    pn2.Width = menubar.Width + 1;
                    pn3.Width = menubar.Width + 1;
                    pn4.Width = menubar.Width + 1;
                    pn5.Width = menubar.Width + 1;
                }
            }
        }

        void resetcolor()
        {
            button1.ForeColor =Color.Black;
            button2.ForeColor =Color.Black;
            button3.ForeColor =Color.Black;
            button4.ForeColor =Color.Black;
            button5.ForeColor =Color.Black;
            button6.ForeColor =Color.Black;
            button7.ForeColor =Color.Black;
            button8.ForeColor =Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetcolor();
            button1.ForeColor = Color.Blue;

            if (mn2 == null) {
                mn2 = new Menu2();
                mn2.FormClosed += Dashboard_FormCloased;
                mn2.MdiParent = this;
                mn2.Dock = DockStyle.Fill;
                mn2.Show();
            }
            else { mn2.Activate(); }
        }

        private void Dashboard_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetcolor();
            button2.ForeColor = Color.Blue;

            admin.Start();
        }

        private void Mn3_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn3 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetcolor();
            button3.ForeColor = Color.Blue;

            if (mn4 == null)
            {
                mn4 = new Menu4();
                mn4.FormClosed += Mn4_FormCloased;
                mn4.MdiParent = this;
                mn4.Dock = DockStyle.Fill;
                mn4.Show();
            }
            else { mn4.Activate(); }
        }

        private void Mn4_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn4 = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetcolor();
            button4.ForeColor = Color.Blue;

            if (mn6 == null)
            {
                mn6 = new Menu6();
                mn6.FormClosed += Mn6_FormCloased;
                mn6.MdiParent = this;
                mn6.Dock = DockStyle.Fill;
                mn6.Show();
            }
            else { mn6.Activate(); }
        }

        private void Mn6_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn6 = null;
        }

        bool admin1 = true;
        private void admin_Tick(object sender, EventArgs e)
        {
            if (admin1==true)
            {
                pnbar.Height += 40;
                if (pnbar.Height >= 392)
                {
                    admin.Stop();
                    admin1 = false;
                }
            }
            else
            {
                pnbar.Height -= 40;
                if (pnbar.Height <= 62)
                {
                    admin.Stop();
                    admin1 = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetcolor();
            button6.ForeColor = Color.Blue;

            if (mn3 == null)
            {
                mn3 = new Menu3();
                mn3.FormClosed += Mn3_FormCloased;
                mn3.MdiParent = this;
                mn3.Dock = DockStyle.Fill;
                mn3.Show();
            }
            else { mn3.Activate(); }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            resetcolor();
            button8.ForeColor = Color.Blue;

            if (dm == null)
            {
                dm = new danhmuc();
                dm.FormClosed += Dm_FormClosed;
                dm.MdiParent = this;
                dm.Dock = DockStyle.Fill;
                dm.Show();
            }
            else { dm.Activate(); }
        }

        private void Dm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dm =null;
        }


        private void menubar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            resetcolor();
            button5.ForeColor = Color.Blue;

            Form1.check = 1;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resetcolor();
            button7.ForeColor = Color.Blue;

            if(mn7 == null)
            {
                mn7 = new Menu7();
                mn7.FormClosed += Mn7_FormClosed;
                mn7.MdiParent = this;
                mn7.Dock = DockStyle.Fill;
                mn7.Show();
            }
            else {  mn7.Activate(); }

        }

        private void Mn7_FormClosed(object sender, FormClosedEventArgs e)
        {
            mn7=null;
        }
    }
}
