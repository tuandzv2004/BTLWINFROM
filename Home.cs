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




        public Home()
        {
            InitializeComponent();
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
                    pn1.Width = menubar.Width;
                    pn2.Width = menubar.Width;
                    pn3.Width = menubar.Width;
                    pn4.Width = menubar.Width;
                    pn5.Width = menubar.Width;
                }
            }
            else
            {
                menubar.Width += 30;
                if (menubar.Width >= 200)
                {
                    menu.Stop();
                    menu1 = true;
                    pn1.Width = menubar.Width;
                    pn2.Width = menubar.Width;
                    pn3.Width = menubar.Width;
                    pn4.Width = menubar.Width;
                    pn5.Width = menubar.Width;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void Mn3_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn3 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            if (mn5 == null)
            {
                mn5 = new Menu5();
                mn5.FormClosed += Mn5_FormCloased;
                mn5.MdiParent = this;
                mn5.Dock = DockStyle.Fill;
                mn5.Show();
            }
            else { mn5.Activate(); }
        }

        private void Mn5_FormCloased(object sender, FormClosedEventArgs e)
        {
            mn5 = null;
        }
    }
}
