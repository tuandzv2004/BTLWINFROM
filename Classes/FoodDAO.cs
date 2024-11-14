using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        public List<Food> getlistfood()
        {
            List<Food> list = new List<Food>();
            string qr = "select * from Food";
            DataTable dt = dtbase.readdata(qr);

            foreach (DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                list.Add(food);
            }

            return list;
        }

        public bool insertfood(string name , int id, float price)
        {
            try{
                dtbase.changedata(String.Format("insert food(name , idCategory,price) values (N'{0}',{1},{2})", name, id, price));
            return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatefood(int idfood,string name, int id, float price)
        {
            try{
                dtbase.changedata(String.Format("update Food set name=N'{0}',idCategory = {1}, price={2} where id = {3}", name, id, price, idfood));

                return true;
            }
            catch { return false; }
        }
        public bool deletefood(int idfood)
        {
            try
            {
                BillInfoDAO.Instance.deletebillinfobyfood(idfood);
                dtbase.changedata(String.Format("delete Food where id ={0}", idfood));

                return true;
            }
            catch { return false; }
        }

        public List<Food> searchfood(string name)
        {
            List<Food> list = new List<Food>();
            string qr = "select * from Food where name like N'%"+name+"%'";
            DataTable dt = dtbase.readdata(qr);

            foreach (DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                list.Add(food);
            }

            return list;
        }
    }
}
