using Mysqlx.Crud;
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
    public partial class Menu3 : Form
    {
        BindingSource fl= new BindingSource();
        public Menu3()
        {
            InitializeComponent();
            dtgfood.DataSource = fl;
            LoadlistFood();
            themfood();
            loaddanhmuc();

            dtgfood.Columns["Name"].HeaderText = "Tên Món";
            dtgfood.Columns["CategoryID"].HeaderText = "ID Danh Mục";
            dtgfood.Columns["Price"].HeaderText = "Giá";
        }

        void LoadlistFood()
        {
            fl.DataSource = FoodDAO.Instance.getlistfood();

        }

        void loaddanhmuc( )
        {
            cbbdanhmuc.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbdanhmuc.DisplayMember = "Name";
        }

        void themfood()
        {
            txttenmon.DataBindings.Add(new Binding("Text",dtgfood.DataSource,"Name",true,DataSourceUpdateMode.Never));
            txtid.DataBindings.Add(new Binding("Text",dtgfood.DataSource,"id", true, DataSourceUpdateMode.Never));
            numgia.DataBindings.Add(new Binding("Value",dtgfood.DataSource,"Price", true, DataSourceUpdateMode.Never));
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadlistFood();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

            if(dtgfood.SelectedCells.Count > 0){
                try
                {
                    int id = (int)dtgfood.SelectedCells[0].OwningRow.Cells["Categoryid"].Value;

                    Category ct = CategoryDAO.Instance.getcategorybyid(id);
                //cbbdanhmuc.SelectedItem =ct;

                int index =-1 ,i=0;
                foreach(Category it in cbbdanhmuc.Items)
                {
                    if(it.ID == ct.ID)
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
            string name =txttenmon.Text;
            int id = (cbbdanhmuc.SelectedItem as Category).ID;
            float price = (float) numgia.Value;
            if (FoodDAO.Instance.insertfood(name, id, price)) 
            {
                MessageBox.Show("Thêm Món Thành Công.");
                LoadlistFood();
            }
            else
            {
                MessageBox.Show("Có Lỗi Sảy Ra.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = txttenmon.Text;
            int id = (cbbdanhmuc.SelectedItem as Category).ID;
            float price = (float)numgia.Value;
            int idfood = Convert.ToInt32(txtid.Text);
            if (FoodDAO.Instance.updatefood(idfood,name, id, price))
            {
                MessageBox.Show("Sửa Món Thành Công.");
                LoadlistFood();
                
            }
            else
            {
                MessageBox.Show("Có Lỗi Sảy Ra.");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int idfood = Convert.ToInt32(txtid.Text);
            if (FoodDAO.Instance.deletefood(idfood))
            {
                MessageBox.Show("Xóa Món Thành Công.");
                LoadlistFood();
                //if(deletefood!=null)
                //    deletefood(this,new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Sảy Ra.");
            }
        }
        List<Food> timfoodbyname(string name)
        {

            List<Food> list = FoodDAO.Instance.searchfood(name);

            return list;

        }
        private void btntim_Click(object sender, EventArgs e)
        {
            fl.DataSource= timfoodbyname(txttimid.Text);
        }

        private void cbbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loaddanhmuc();
        }

        private void cbbdanhmuc_Click(object sender, EventArgs e)
        {

            loaddanhmuc();
        }
    }
}
