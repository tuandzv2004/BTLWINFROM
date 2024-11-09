﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    public class Category
    {
        public Category(int id, string name) {
        this.ID = id;
            this.Name = name;
        }

        public Category(DataRow row)
        {
            this.ID = (int )row["ID"];
            this.Name= row["Name"].ToString();
        }

        private string name;

        public string Name { get { return name; } set { name = value; } }

        private int iD;
        
        public int ID { get { return iD; } set { iD = value; } }
    }
}
