using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quanlynhahang.Classes
{
    public class AccountDAO
    {
        a dtbase = new a();

        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        public Account GetAccountbyusername(string username)
        {
            DataTable dt = dtbase.readdata("select * from account where UserName = '"+username+"'");
            foreach (DataRow dr in dt.Rows) 
            {
                return new Account(dr);
            }
            return null;
        }

        public DataTable layacc()
        {
            return dtbase.readdata("select UserName, Name, Type from Account");
        }

        public bool insertacc(string UserName, String Name, int type)
        {
            try
            {
                dtbase.changedata(String.Format("insert Account(UserName , Name,Type) values (N'{0}',N'{1}',{2})", UserName, Name, type));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateacc( string UserName, String Name, int type)
        {
            try
            {
                dtbase.changedata(String.Format("update Account set Name = N'{1}', Type={2} where UserName=N'{0}'", UserName, Name, type));

                return true;
            }
            catch { return false; }
        }
        public bool deleteacc(string username)
        {
            try
            {

                dtbase.changedata(String.Format("delete Account where UserName =N'{0}'", username));

                return true;
            }
            catch { return false; }
        }

        public bool resetpassword(string name)
        {
            try
            {

                dtbase.changedata(String.Format("update Account set PassWord = N'0' where UserName=N'{0}'", name));

                return true;
            }
            catch { return false; }
        }
    }
}
