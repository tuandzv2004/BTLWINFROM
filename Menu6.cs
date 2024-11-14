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
using System.Xml.Linq;

namespace quanlynhahang
{

        
    public partial class Menu6 : Form
    {

        BindingSource dmuc = new BindingSource();
        public Menu6()
        {
            InitializeComponent();
            dtgdanhmuc.DataSource = dmuc;
            loaddata();
            loadid();
        }
        void loaddanhmuc()
        {
            cbbdanhmuc.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbdanhmuc.DisplayMember = "Name";
        }
        void loaddata()
        {
            dmuc.DataSource = CategoryDAO.Instance.GetListCategory();
            loaddanhmuc();
        }
        void loadid()
        {
            txtid.DataBindings.Add(new Binding("Text", dtgdanhmuc.DataSource, "id", true, DataSourceUpdateMode.Never));

        }
        private void Menu6_Load(object sender, EventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (dtgdanhmuc.SelectedCells.Count > 0)
            {
                try
                {
                    int id = (int)dtgdanhmuc.SelectedCells[0].OwningRow.Cells["id"].Value;

                    Category ct = CategoryDAO.Instance.getcategorybyid(id);
                    //cbbdanhmuc.SelectedItem =ct;

                    int index = -1, i = 0;
                    foreach (Category it in cbbdanhmuc.Items)
                    {
                        if (it.ID == ct.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbbdanhmuc.SelectedIndex = index;

                }
                catch { }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string name = cbbdanhmuc.Text;
            if (CategoryDAO.Instance.insertcategory(name) == true)
            {
                MessageBox.Show("Thêm danh mục thành công.");
                loaddata();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            if (CategoryDAO.Instance.deletecategory(id) == true)
            {
                MessageBox.Show("Xóa danh mục thành công.");
                loaddata();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = cbbdanhmuc.Text;
            int id = int.Parse(txtid.Text);
            if (CategoryDAO.Instance.editcategory(name,id) == true)
            {
                MessageBox.Show("Cập nhật danh mục thành công.");
                loaddata();
            }
            else
            {
                MessageBox.Show("Có Lỗi Gì Đó.");
            }
        }
    }
}
