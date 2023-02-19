using System;
using System.Windows.Forms;

namespace myKEP
{
    public partial class myKEP : Form
    {
        public myKEP()
        {
            InitializeComponent();
            
            
        }
        private Form currentForm;
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //fit the appropriate form in the panel
        private void SelectForm(Form nextForm)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = nextForm;
            nextForm.TopLevel = false;
            nextForm.FormBorderStyle = FormBorderStyle.None;
            nextForm.Dock = DockStyle.Fill;
            this.Screen.Controls.Add(nextForm);
            nextForm.BringToFront();
            nextForm.Show();
        }

        //check whether a user with this AT exists
        private void newReqBtn_Click(object sender, EventArgs e)
        {
            PopupAT popup = new PopupAT();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool userExists = DBHandler.UserExists(popup.Response.Text);

                if (userExists)
                {
                    SelectForm(new NewReq(popup.Response.Text));
                }
                else
                {
                    MessageBox.Show("Αυτός ο χρήστης δεν υπάρχει", "Message");
                }
                popup.Dispose();
            }
        }

        private void listReqBtn_Click(object sender, EventArgs e)
        {
            SelectForm(new View());
        }

        //check whether a request with this code exists
        private void editReqBtn_Click(object sender, EventArgs e)
        { 
            PopupReqCode popup = new PopupReqCode();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool codeExists = DBHandler.RequestExists(popup.Response.Text);
                if (codeExists)
                {
                    SelectForm(new EditReq(popup.Response.Text));

                } else
                {
                    MessageBox.Show("Δεν υπάρχει αίτηση με αυτό τον κωδικό", "Message");
                }
                popup.Dispose();
            }

        }

        //delete user or request
        private void delReqBtn_Click(object sender, EventArgs e)
        {
            PopupDel popup = new PopupDel();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                if (popup.delResponse.Text == "Διαγραφή χρήστη")
                {
                    PopupAT popAT = new PopupAT();
                    if (popAT.ShowDialog(this) == DialogResult.OK)
                    {
                        DBHandler.DeleteUser(popAT.Response.Text);
                    }
                } else if (popup.delResponse.Text == "Διαγραφή αίτησης")
                {
                    PopupReqCode popCode = new PopupReqCode();
                    if (popCode.ShowDialog(this) == DialogResult.OK)
                    {
                        DBHandler.DeleteRequest(popCode.Response.Text);
                    }
                }
                    
            }
            popup.Dispose();
        }
        

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            SelectForm(new NewUser());
        }

        //edit user, if a user with the AT exists
        private void editUserBtn_Click(object sender, EventArgs e)
        {
            PopupAT popup = new PopupAT();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool userExists = DBHandler.UserExists(popup.Response.Text);

                if (userExists)
                {
                    SelectForm(new EditUser(popup.Response.Text));
                }
                else
                {
                    MessageBox.Show("Αυτός ο χρήστης δεν υπάρχει", "Message");
                }
                popup.Dispose();
            }
        }

        private void listText_Click(object sender, EventArgs e)
        {
            listReqBtn_Click(sender, e);
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void addText_Click(object sender, EventArgs e)
        {
            newUserBtn_Click(sender, e);
        }

        private void editUsrLabel_Click(object sender, EventArgs e)
        {
            editUserBtn_Click(sender, e);
        }

        private void newReqLabel_Click(object sender, EventArgs e)
        {
            newReqBtn_Click(sender, e);
        }

        private void editReqLabel_Click(object sender, EventArgs e)
        {
            editReqBtn_Click(sender, e);
        }

        private void delText_Click(object sender, EventArgs e)
        {
            delReqBtn_Click(sender, e);
        }
    }
}
