using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using SQLite;

namespace myKEP
{
    public partial class NewReq : Form
    {
        public NewReq()
        {
            InitializeComponent();
            
        }

       

        private void myKEP_Load(object sender, EventArgs e)
        {
            initDB();
        }

        private void initDB()
        {
            if (System.IO.File.Exists("KEP.db"))
            {

            } 
            else
            {
                var kepDB = new SQLiteConnection("KEP.db");
                kepDB.CreateTable<usersDB>();
                kepDB.CreateTable<reqDB>();
                kepDB.Close();
            }
        }

        private void typeManu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reqEnterButton_Click(object sender, EventArgs e)
        {
            bool emptyFields = false;

            if (string.IsNullOrEmpty(nameField.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(surnameField.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty (phoneField.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(emailField.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(addressField.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(typeField.Text))
            {
                emptyFields = true;
            } else if (dobPicker.Value.Date >= DateTime.Today)
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(ATField.Text))
            {
                emptyFields = true;
            }

            if (emptyFields)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία");
            }
           
            
        }

        private void ATLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
