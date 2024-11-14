using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class BillDAO
    {
        a dtbase=new a();
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { instance = value; }
        }

        private BillDAO() {
        
        }

        public void checkout(int id, int discount, float totalPrice)
        {
            dtbase.changedata("update dbo.Bill set dateCheckOut = GETDATE(), status = 1 , discount= "+discount+" , totalPrice = "+totalPrice+" where id = " + id);
        }

        public int GetUnchheckBillIDByTableID(int id) {
            a database = new a();
            DataTable dt = database.readdata("Select * from dbo.Bill Where idTable="+id+" and status = 0");
            if (dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
         public void InsertBill(int id)
        {
            dtbase.changedata("exec USP_InsertBill "+ id);
        }

        public DataTable getlistbydate(DateTime checkin, DateTime checkout)
        {
            return dtbase.readdata("exec USP_getlistbydate '" + checkin + "','" + checkout+"'");
        }

        public int GetMaxID()
        {
            try
            {
                DataTable dt = dtbase.readdata("select max(id) from Bill");
                return (int)dt.Rows[0]["id"];
            }
            catch {
            return 1;
            }
        }
    }
}
