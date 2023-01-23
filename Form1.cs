using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //initControlLists();
            //initPointLists();
        }

        //private List<Control> newEntryElements;
        //private List<Point> newEntryPoints;
        //private List<Control> editEntryElements;
        //private List<Point> editEntryPoints;

        //private void initControlLists()
        //{
        //    this.newEntryElements = new List<Control>()
        //    {
        //        this.newReqLabel, this.nameLabel, this.nameText, this.surnameLabel, this.surnameText, this.phoneLabel, this.phoneText, this.emailLabel, this.emailText,
        //        this.dobLabel, this.dobPicker, this.addressLabel, this.addressText, this.ATLabel, this.ATText, this.typeLabel, this.typeManu, this.reqEnterButton
        //    };

        //    this.editEntryElements = new List<Control>()
        //    {
        //        this.reqEditLabel, this.nameLabel, this.nameText, this.surnameLabel, this.surnameText, this.phoneLabel, this.phoneText, this.emailLabel, this.emailText,
        //        this.dobLabel, this.dobPicker, this.prevDateLabel, this.addressLabel, this.addressText, this.ATLabel, this.ATText, this.typeLabel, this.typeManu, this.reqEditButton
        //    };
        //}

        //private void initPointLists()
        //{
        //    this.newEntryPoints = new List<Point>()
        //    {
        //        new Point(330, 20), new Point(206, 127), new Point(210, 150), new Point(206, 207), new Point(210, 230), new Point(206, 287), new Point(210, 310), new Point(206, 367), new Point(210, 390), 
        //        new Point(471, 127), new Point(475, 150), new Point(471, 186), new Point(475, 230), new Point(471, 287), new Point(475, 310), new Point(471, 367), new Point(475, 390), new Point(338, 536)
        //    };

        //    this.editEntryPoints = new List<Point>()
        //    {
        //        new Point(270, 30), new Point(206, 127), new Point(210, 150), new Point(206, 207), new Point(210, 230), new Point(206, 287), new Point(210, 310), new Point(206, 367), new Point(210, 390),
        //        new Point(471, 127), new Point(475, 150), new Point(631,153), new Point(471, 186), new Point(475, 230), new Point(471, 287), new Point(475, 310), new Point(471, 367), new Point(475, 390), new Point(338, 536)
        //    };
        //}
        
       

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

        //private void hideHomeElements()
        //{
        //    avatarPB.Visible = false;
        //    welcome.Visible = false;
        //    add.Visible = false;
        //    delete.Visible = false;
        //    edit.Visible = false;
        //    list.Visible = false;
        //    addText.Visible = false;
        //    editText.Visible = false;
        //    listText.Visible = false;
        //    delText.Visible = false;
        //    back.Visible = true;
        //}

        //private void showHomeElements()
        //{
        //    avatarPB.Visible = true;
        //    welcome.Visible = true;
        //    add.Visible = true;
        //    delete.Visible = true;
        //    edit.Visible = true;
        //    list.Visible = true;
        //    addText.Visible = true;
        //    editText.Visible = true;
        //    listText.Visible = true;
        //    delText.Visible = true;
        //    back.Visible = false;

        //    foreach (Control control in newEntryElements)
        //    {
        //        control.Visible = false;
        //    }

        //    foreach (Control control in editEntryElements)
        //    {
        //        control.Visible = false;
        //    }
        //}

        //private void showAddReqElements()
        //{
        //    for (int i=0; i < newEntryElements.Count; i++)
        //    {
        //        newEntryElements[i].Location = newEntryPoints[i];
        //    }
        //    foreach (Control element in newEntryElements)
        //    {
        //        element.Visible = true;
        //    }
        //}

        //private void showEditReqElements()
        //{
        //    for (int i=0; i < editEntryElements.Count; i++)
        //    {
        //        editEntryElements[i].Location = editEntryPoints[i];
        //    }
        //    foreach (Control control in editEntryElements)
        //    {
        //        control.Visible = true;
        //    }
        //}


        private void addText_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            newReqPanel.Visible = true;
        }

        private void delText_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            delReqPanel.Visible = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            newReqPanel.Visible = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            editReqPanel.Visible = true;
        }

        private void list_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            delReqPanel.Visible = true;
        }

        private void editText_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
            editReqPanel.Visible = true;
        }

        private void listText_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            back.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            back.Visible = false;
        }

        private void reqEnterButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
