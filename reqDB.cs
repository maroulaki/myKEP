using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myKEP
{
    internal class reqDB
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }

        reqDB(int id, string type, string date)
        {
            userID = id;
            Type = type;
            Date = date;
        }


    }
}
