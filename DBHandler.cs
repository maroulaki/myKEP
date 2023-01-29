﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKEP
{
    public class DBHandler
    {
        //public void initDB()
        //{
        //    //Connection
        //    //
        //    if (!System.IO.File.Exists("KEP1.mdf"))
        //    {

        //    }
        //    else
        //    {
        //        var kepDB = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        //        kepDB.Open();
        //        string qSearchByAT = "SELECT reqNo FROM usersDB WHERE AT=@Parameter;";
        //        var cmd = new SqlCommand(qSearchByAT, kepDB);
        //        cmd.Parameters.AddWithValue("@Parameter", );



        //    }
        //}


        //Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        public void test()
        {
            var kepDB = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            kepDB.Open();
            kepDB.Close();
        }
        public void insertUser(usersDB User)
        {
            var kepDB = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string qSearchByAT = "SELECT reqNo FROM usersDB WHERE AT=@Parameter;";
            kepDB.Open();
            var cmd = new SqlCommand(qSearchByAT, kepDB);
            cmd.Parameters.AddWithValue("@Parameter", User.AT.ToString());

            int userExists = cmd.ExecuteNonQuery();
            MessageBox.Show(userExists.ToString());
            kepDB.Close();
        }
    }




}
