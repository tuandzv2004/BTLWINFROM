using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quanlynhahang.Classes
{
    public class CategoryDAO
    {
        a dtbase = new a();

        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory() {
        List<Category> list = new List<Category>();

            string qr = "Select * from FoodCategory";

            DataTable dt = dtbase.readdata(qr);

            

            foreach (DataRow dr in dt.Rows) {
                Category ct = new Category(dr);
                list.Add(ct);
            }
            
            return list;

        }

        public Category getcategorybyid(int id)
        {
            Category ct=null;
            string qr = "Select * from FoodCategory where id = "+id;

            DataTable dt = dtbase.readdata(qr);

            foreach (DataRow dr in dt.Rows)
            {
                ct = new Category(dr);
            }

            return ct;
        }
        public bool insertcategory(string name)
        {
            try
            {
                dtbase.changedata("insert into FoodCategory ( name) values (N'" + name + "')");
                return true;
            }
            catch { 
            

                return false;
                }
        }
        public bool deletecategory(int id) {
            try
            {
                dtbase.changedata("delete Food where idCategory = " + id );
                dtbase.changedata("delete FoodCategory where id = " + id );
                return true;
            }
            catch
            {


                return false;
            }

        }
        public bool editcategory(string name, int id) {
            try
            {
                dtbase.changedata("update FoodCategory set name = N'"+name+"' where id = "+id);
                   return true;
            }
            catch
            {


                return false;
            }
        }
    }
}
