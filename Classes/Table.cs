using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class Table
    {
        a dtbase =new a();
        private static Table instance;  // Biến instance dùng để lưu trữ duy nhất

        public static Table Instance
        {
            get
            {
                if (instance == null)
                    instance = new Table();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void chuyenban(int id1,int id2)
        {
            string qr = "exec UTP_chuyenban " +id1+","+id2;
            dtbase.changedata(qr);
        }

        // Phương thức khởi tạo (constructor) có thể để private để ngăn tạo thêm đối tượng
        private Table() { }

        public List<TableList> LoadTableList()
        {
            List<TableList> tableLists = new List<TableList>();

            a dtbase = new a();

            DataTable dt = dtbase.readdata("exec dbo.USP_GetTableList");

            foreach (DataRow item in dt.Rows) 
            {
                TableList table = new TableList(item);
                tableLists.Add(table);
            }

            return tableLists;
        }
    }
}
