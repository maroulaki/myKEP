using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myKEP
{
    public class Request
    { 
        public string Type { get; set; }
        public string Date { get; set; }
        public string AT { get; set; }
        public string reqID { get; set; }

        

        public Request(string type, string date, string userID, string ID)
        {
            Type = type;
            Date = date;
            AT = userID;
            reqID = ID;
        }


    }
}
