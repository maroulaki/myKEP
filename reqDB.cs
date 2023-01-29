using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myKEP
{
    public class reqDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string AT { get; set; }
        public int reqID { get; set; }

        

        public reqDB(int user, string type, string date, string userID, int ID)
        {
            Type = type;
            Date = date;
            AT = userID;
            reqID = ID;
        }


    }
}
