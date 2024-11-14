using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public bool inserttable(string name)
        {
            try {
                dtbase.changedata("insert into TableFood (name) values (N'"+name+"')");
                return true;
            }
            catch { 
            
                return false;
            }
        }

        public bool deletetable(int id) 
        {
            try
            {
                DataTable dt = dtbase.readdata("select b.id from Bill as b join TableFood as tb on tb.id = b.idTable where tb.id = " + id);
                int id1 = int.Parse(dt.Rows[0]["id"].ToString());

                dtbase.changedata("delete BillInfo where idBill = " + id1);
                dtbase.changedata("delete Bill where idTable = "+id);
                dtbase.changedata("delete TableFood where id = " + id);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool edittable(int id,string name, string status)
        {
            try
            {
                dtbase.changedata("update TableFood set name = N'"+name+"', status = N'"+status+"' where id = "+id);
                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}
