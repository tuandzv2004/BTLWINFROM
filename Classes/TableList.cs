using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class TableList
    {
        public TableList(int id, string name, string status) {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public TableList(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        public static int ButtonWidth = 100;
        public static int ButtonHeight = 100;

        public string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        private string name;

        public string Name 
        {
            get {  return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
           
        }    
    }
}
