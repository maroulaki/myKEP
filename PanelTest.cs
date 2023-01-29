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
            //KEPdb.initDB();
        }
        private Form currentForm;
        private DBHandler KEPdb;

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void Head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void avatarPB_Click(object sender, EventArgs e)
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
            //this.Screen.Tag = form;
            nextForm.BringToFront();
            nextForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SelectForm(new NewReq());
        }

        private void list_Click(object sender, EventArgs e)
        {

        }

    }
}
