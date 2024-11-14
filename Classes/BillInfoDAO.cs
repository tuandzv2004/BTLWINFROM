using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class BillInfoDAO
    {
        a dtbase = new a();
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) { instance = new BillInfoDAO(); } return BillInfoDAO.instance; }
            set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO()
        
            { }

        public List<BillInfo> GetListBillInfo(int id) {
            List<BillInfo> listBillIndo= new List<BillInfo>();

            a dtbase = new a();
            DataTable dt = dtbase.readdata("select * from dbo.BillInfo where idBill="+id);

            foreach (DataRow dr in dt.Rows) 
            {
                BillInfo info = new BillInfo(dr);
                listBillIndo.Add(info);
            }

            return listBillIndo;
        }
        public void InsertBillInfo(int idBill, int idFood,int count)
        {
            dtbase.changedata("exec USP_InsertBillInfo " + idBill+","+idFood+","+count);
        }
        public void deletebillinfobyfood(int id)
        {
            dtbase.changedata("delete BillInfo where idFood = " + id);
        }

    }
}
