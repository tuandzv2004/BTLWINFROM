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
    public partial class Menu7 : Form
    {

        BindingSource ba=new BindingSource();
        public Menu7()
        {
            InitializeComponent();
            dtgban.DataSource=ba;
            loaddata();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void loadban()
        {
            ba.DataSource = Table.Instance.LoadTableList();

            dtgban.Columns["name"].HeaderText = "Tên Bàn";
            dtgban.Columns["status"].HeaderText = "Trạng Thái";
        }

        void loaddata()
        {
            txtid.DataBindings.Add(new Binding("Text", dtgban.DataSource, "id", true, DataSourceUpdateMode.Never));
            txttenban.DataBindings.Add(new Binding("Text", dtgban.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txttrangthai.DataBindings.Add(new Binding("Text", dtgban.DataSource, "status", true, DataSourceUpdateMode.Never));
            loadban();

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            loadban();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string name = txttenban.Text;
            if (Table.Instance.inserttable(name) == true)
            {
                MessageBox.Show("Thêm Bàn Thành Công.");
                loadban();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            if (Table.Instance.deletetable(id) == true)
            {
                MessageBox.Show("Xóa Bàn Thành Công.");
                loadban();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = txttenban.Text;
            int id= int.Parse(txtid.Text);
            string status= txttrangthai.Text;
            if (Table.Instance.edittable(id,name,status) == true)
            {
                MessageBox.Show("Cập Nhật Bàn Thành Công.");
                loadban();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }
    }
}
