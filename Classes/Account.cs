using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class Account
    {
        public Account(string name, string username, int type, string password = null)
        {
            this.Name = name;
            this.Username = username;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Username = row["UserName"].ToString();
            this.Type = (int)row["Type"];
            this.password = row["Password"].ToString();
        }

        private int type;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
