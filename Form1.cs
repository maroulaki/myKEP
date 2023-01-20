using System;
using System.Windows.Forms;
using SQLite;

namespace myKEP
{
    public partial class myKEP : Form
    {
        public myKEP()
        {
            InitializeComponent();
             
        }

        private void myKEP_Load(object sender, EventArgs e)
        {
            avatarPB.BorderStyle = BorderStyle.None;
            add.BorderStyle = BorderStyle.None;
            edit.BorderStyle = BorderStyle.None;
            list.BorderStyle = BorderStyle.None;
            delete.BorderStyle = BorderStyle.None;
            initDB();
        }

        private void initDB()
        {
            if (!System.IO.File.Exists("KEP.db"))
            {
                var kepDB = new SQLiteConnection("KEP.db");
                kepDB.CreateTable<usersDB>();
                kepDB.CreateTable<reqDB>();
                kepDB.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addText_Click(object sender, EventArgs e)
        {

        }

        private void delText_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void editText_Click(object sender, EventArgs e)
        {

        }

        private void listText_Click(object sender, EventArgs e)
        {

        }

       
    }
}
