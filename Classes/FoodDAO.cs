using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class FoodDAO
    {
        a dtbase =new a();
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodList(int id) {
            List<Food> list = new List<Food>();
            string qr = "select * from Food where idCategory = "+id;
            DataTable dt= dtbase.readdata(qr);

            foreach (DataRow dr in dt.Rows) 
            {
                Food food = new Food(dr);
                list.Add(food);
            }

            return list;
        }


    }
}
