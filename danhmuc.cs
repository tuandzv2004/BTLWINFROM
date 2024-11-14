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
    public partial class danhmuc : Form
    {
        public danhmuc()
        {
            InitializeComponent();
            loadtime();
            loadlistbillbydate(dtpk1.Value, dtpk2.Value);
        }

        void loadtime()
        {
            DateTime today = DateTime.Now;
            dtpk1.Value = new DateTime(today.Year, today.Month, 1);
            dtpk2.Value = dtpk1.Value.AddMonths(1).AddDays(-1);
        }

        void loadlistbillbydate(DateTime checkin, DateTime checkout)
        {
            dtgtk.DataSource =  BillDAO.Instance.getlistbydate(checkin, checkout);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            loadlistbillbydate(dtpk1.Value, dtpk2.Value);
        }

        private void dtgtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
