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
    public partial class Menu4 : Form
    {
        public static string us;
        BindingSource al = new BindingSource();
        public Menu4()
        {
            InitializeComponent();
            dtgaccc.DataSource = al;
            loadacc();
            themacc();
        }

        void themacc()
        {
            txttentk.DataBindings.Add(new Binding("Text",dtgaccc.DataSource,"UserName", true, DataSourceUpdateMode.Never));
            txttenht.DataBindings.Add(new Binding("Text",dtgaccc.DataSource,"Name", true, DataSourceUpdateMode.Never));
            txtloaitk.DataBindings.Add(new Binding("Text",dtgaccc.DataSource,"Type",true,DataSourceUpdateMode.Never));
            
        }
        void loadacc()
        {
            al.DataSource = AccountDAO.Instance.layacc();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            loadacc();
        }

        private void txtloaitk_TextChanged(object sender, EventArgs e)
        {
            if (txtloaitk.Text == "1")
            {
                txtloaitk.Text = "Quản Lý";
            }
            if (txtloaitk.Text == "0")
            {
                txtloaitk.Text = "Nhân Viên";
            }
        }

        void themaccount(string username, string name, int type)
        {
            if (AccountDAO.Instance.insertacc(username, name, type) == true)
            {
                MessageBox.Show("Thêm tài khoản thành công");

            }
            else {
                MessageBox.Show("Có Lỗi Gì Đó");
            }
            loadacc();
        }
        void suaaccount(string username, string name, int type)
        {
            if (AccountDAO.Instance.updateacc(username, name, type) == true)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó");
            }
            loadacc();
        }
        void xoaaccount(string username)
        {
            if (us.Equals(username))
            {
                MessageBox.Show("Tài khoản này bạn đang đăng nhập không thể xóa!");
                return;
            }
            if (AccountDAO.Instance.deleteacc(username) == true)
            {
                MessageBox.Show("Xóa tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó");
            }
            loadacc();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string username = txttentk.Text;
            string name = txttenht.Text;
            string type = txtloaitk.Text;
            int i=-1;
            if(type =="Quản Lý")
            {
                i = 1;
            }

            if (type == "Nhân Viên")
            {
                i = 0;
            }

            themaccount(username,name,i);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string username = txttentk.Text;
            xoaaccount(username);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string username = txttentk.Text;
            string name = txttenht.Text;
            string type = txtloaitk.Text;
            int i = -1;
            if (type == "Quản Lý")
            {
                i = 1;
            }

            if (type == "Nhân Viên")
            {
                i = 0;
            }

            suaaccount(username, name, i);
        }
        
        void resetpassword(string name)
        {
            if (AccountDAO.Instance.resetpassword(name) == true)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else {
                MessageBox.Show("Lỗi gì đó.");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetpassword(txttentk.Text);
        }
    }
}
