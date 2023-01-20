using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace myKEP
{
    internal class usersDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public int reqNo { get; set; }
        

        usersDB (string name, string surname, string email, string phone, string dob, string address, int no)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DateOfBirth = dob;
            Address = address;
            reqNo = no;
        }

    }
}
