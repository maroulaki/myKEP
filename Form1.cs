using System;
using System.Drawing;
using System.Windows.Forms;
using SQLite;

namespace myKEP
{
    public partial class Form1 : Form
    {
        public Form1()
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
            back.Visible = false;
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

        private void hideHomeElements()
        {
            avatarPB.Visible = false;
            welcome.Visible = false;
            add.Visible = false;
            delete.Visible = false;
            edit.Visible = false;
            list.Visible = false;
            addText.Visible = false;
            editText.Visible = false;
            listText.Visible = false;
            delText.Visible = false;
            back.Visible = true;
        }

        private void showHomeElements()
        {
            avatarPB.Visible = true;
            welcome.Visible = true;
            add.Visible = true;
            delete.Visible = true;
            edit.Visible = true;
            list.Visible = true;
            addText.Visible = true;
            editText.Visible = true;
            listText.Visible = true;
            delText.Visible = true;
            back.Visible = false;
        }

        private void showAddReqElements()
        {
            newReqLabel.Location = new Point(330, 20);
            newReqLabel.Visible = true;
            nameLabel.Location = new Point(206, 127);
            nameLabel.Visible = true;
            surnameLabel.Location = new Point(206, 207);
            surnameLabel.Visible = true;
            phoneLabel.Location = new Point(206, 287);
            phoneLabel.Visible = true;
          
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void addText_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void delText_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void add_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void list_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void editText_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void listText_Click(object sender, EventArgs e)
        {
            hideHomeElements();
        }

        private void back_Click(object sender, EventArgs e)
        {
            showHomeElements();
        }
    }
}
