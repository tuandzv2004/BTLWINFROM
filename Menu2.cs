using quanlynhahang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = quanlynhahang.Classes.Menu;

namespace quanlynhahang
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
            loadtable();
            LoadCategory();
            loadcbbtable(cbbban);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadCategory()
        {
            List<Category> listcategory= CategoryDAO.Instance.GetListCategory();
            cbbloai.DataSource = listcategory;
            cbbloai.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listfood = FoodDAO.Instance.GetFoodList(id);
            cbbmon.DataSource = listfood;
            cbbmon.DisplayMember= "Name";
        }


        public void loadtable()
        {
            flptable.Controls.Clear();
            List<TableList> tablelist = Table.Instance.LoadTableList();
            foreach (TableList table in tablelist) 
            {
                Button btn = new Button() {Width = TableList.ButtonWidth, Height=TableList.ButtonHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += btn_Click;
                btn.Tag =table;
                
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                flptable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear(); 
            List<quanlynhahang.Classes.Menu> listBillInfo= MenuDAO.Instance.GetListMenuByTable(id);

            float tongtien=0;

            foreach (quanlynhahang.Classes.Menu item in listBillInfo) {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                tongtien += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txttongtien.Text = tongtien.ToString("c",culture);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID=((sender as Button).Tag as TableList).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=0;

            ComboBox cb = sender as ComboBox;  
            if(cb.SelectedItem == null)
                return;


            Category sl= cb.SelectedItem    as Category;
            id= sl.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            TableList table= lsvBill.Tag as TableList;
            if (table == null)
            {
                MessageBox.Show("hãy chọn bàn.");
                return;
            }
            int idBill = BillDAO.Instance.GetUnchheckBillIDByTableID(table.ID);
            int idFood= (cbbmon.SelectedItem as Food).Id;
            int count = (int)nudsoluong.Value;
            
            if(idBill == -1) { 
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxID(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);

            }
            ShowBill(table.ID);
            loadtable();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            TableList table = lsvBill.Tag as TableList;
            int discount = (int)nugiamgia.Value;
            int idbill = BillDAO.Instance.GetUnchheckBillIDByTableID(table.ID);
            string tongtienText = txttongtien.Text.Replace("₫", "").Replace(".", "").Trim();
            float tongtien = float.Parse(tongtienText.Split(',')[0]);
            float tientra = tongtien - tongtien * discount / 100;

            
            if (idbill != -1) 
            {
                if(MessageBox.Show(string.Format("Bạn chắc chắn muốn thanh toán hóa đơn {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá \n=> {1} - ({1} / 100 x {2}) = {3} đ",table.Name,tongtien,discount,tientra),"Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.checkout(idbill,discount,tientra);
                    ShowBill(table.ID);
                    loadtable();
                }
            }
        }
         void loadcbbtable(ComboBox cb)
        {
            cb.DataSource = Table.Instance.LoadTableList();
            cb.DisplayMember= "Name";
        }
        private void btnchuyenban_Click(object sender, EventArgs e)
        {
            try { 
            int id1 = (lsvBill.Tag as TableList).ID;
            int id2 = (cbbban.SelectedItem as TableList).ID;
            if(MessageBox.Show(string.Format("bạn chắc chắn muốn chuyển {0} qua {1}", (lsvBill.Tag as TableList).Name, (cbbban.SelectedItem as TableList).Name),"Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            Table.Instance.chuyenban(id1, id2);
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Bàn");
            }
            loadtable();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            try
            {
                Menu5.id = (lsvBill.Tag as TableList).ID;
            TableList table = lsvBill.Tag as TableList;
            int discount = (int)nugiamgia.Value;
            int idbill = BillDAO.Instance.GetUnchheckBillIDByTableID(table.ID);
            string tongtienText = txttongtien.Text.Replace("₫", "").Replace(".", "").Trim();
            float tongtien = float.Parse(tongtienText.Split(',')[0]);
            Menu5.tongsotien = tongtien - tongtien * discount / 100;


            Menu5 mn5 = new Menu5();
            mn5.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Bàn");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadtable();
        }
    }
    }

