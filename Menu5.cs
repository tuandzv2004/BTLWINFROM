using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhahang
{
    public partial class Menu5 : Form
    {
        Classes.a dtbase = new Classes.a();
        public static int discount;
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public static int id;
        public static float tongsotien;
        public Menu5()
        {
            InitializeComponent();
        }

        private void Menu5_Load(object sender, EventArgs e)
        {
            load(id);
        }

        void load(int id1)
        {
            string qr = "select f.name as [Tên Món] , bf.count as [Số Lượng], f.price as [Giá],b.discount as [Giảm Giá], (f.price*bf.count)*(100-b.discount)/100 as [Tổng Tiền] from BillInfo as bf join Bill as b on bf.idBill=b.id join Food as f on f.id = bf.idFood join TableFood tb on tb.id = b.idTable where  tb.id="+id1+" and b.status =0";
            DataTable dt = dtbase.readdata(qr) ;
            dataGridView1.DataSource = dt ;
            for (int i =  1; i < 3; i++)
            {
                // Thêm một dòng trống 
                DataRow emptyRow = dt.NewRow();
                dt.Rows.Add(emptyRow);
            }
            DataRow hangTongCong = dt.NewRow();
            hangTongCong[0] = "Tổng cộng: ";  // Đặt tên cho hàng tổng cộng
            hangTongCong[4] = tongsotien.ToString("N0"); // Đặt tổng số tiền vào cột thứ 4
            dt.Rows.Add(hangTongCong);


            string ngayHienTai = DateTime.Now.ToString("dd/MM/yyyy");
            DataRow ngay = dt.NewRow();
            ngay[0] = "Ngày: "+ngayHienTai;
            dt.Rows.Add(ngay);

            for(int i = 0; i < dt.Rows.Count - 4; i++)
            {

                dt.Rows[i]["Giảm Giá"] = discount;
            }

            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 100; // Vị trí X bắt đầu
            int y = 100; // Vị trí Y bắt đầu
            int rowHeight = 30; // Chiều cao của mỗi hàng

            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // In tiêu đề của các cột
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, font, brush, x, y);
                x += col.Width;
            }

            y += rowHeight; // Chuyển xuống dòng tiếp theo để in dữ liệu
            x = 100; // Đặt lại vị trí X cho mỗi hàng mới

            // In từng hàng dữ liệu
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        e.Graphics.DrawString(cell.Value?.ToString() ?? "", font, brush, x, y);
                        x += dataGridView1.Columns[cell.ColumnIndex].Width;
                    }
                    y += rowHeight;
                    x = 100; // Đặt lại vị trí X cho mỗi hàng mới
                }
            }
        }



    }
}
