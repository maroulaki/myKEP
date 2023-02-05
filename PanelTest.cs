using System;
using System.Windows.Forms;

namespace myKEP
{
    public partial class PanelTest : Form
    {
        public PanelTest()
        {
            InitializeComponent();
            KEPdb = new DBHandler();
            
        }
        private Form currentForm;
        private DBHandler KEPdb;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

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

        private void newReqBtn_Click(object sender, EventArgs e)
        {
            PopupAT popup = new PopupAT();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool userExists = KEPdb.UserExists(popup.Response.Text);

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

        }

        private void editReqBtn_Click(object sender, EventArgs e)
        { 
            PopupReqCode popup = new PopupReqCode();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool codeExists = KEPdb.RequestExists(popup.Response.Text);
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

        private void delReqBtn_Click(object sender, EventArgs e)
        {

        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            SelectForm(new NewUser());
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            PopupAT popup = new PopupAT();

            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                bool userExists = KEPdb.UserExists(popup.Response.Text);

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
    }
}
