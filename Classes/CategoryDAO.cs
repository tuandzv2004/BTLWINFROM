using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
