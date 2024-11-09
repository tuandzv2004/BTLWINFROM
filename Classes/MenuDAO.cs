﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id) 
        {
            List<Menu> listMenu = new List<Menu>();
            
            a dtbase= new a();
            DataTable dt = dtbase.readdata("select f.name, bi.count,f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f where bi.idBill= b.id and bi.idFood = f.id and b.status=0 and b.idTable = "+id);
            foreach (DataRow dr in dt.Rows) {
                Menu menu = new Menu(dr);
                listMenu.Add(menu); 
            }
            
            return listMenu;
        }

    }
}
