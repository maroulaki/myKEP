using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKEP
{
    public partial class NewReq : Form
    {
        User user;
        public NewReq(string AT)
        {
            InitializeComponent();
            user = DBHandler.FetchUser(AT);
        }

        private void newReqButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typeField.Text))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε σωστά όλα τα πεδία", "Message");
            }
            else
            {
                Request request = new Request(typeField.Text, DateTime.Now.ToString(), user.AT, DBHandler.RequestIDGen());
                DBHandler.InsertRequest(user, request);
            }
        }

        private void NewReq_Load(object sender, EventArgs e)
        {

        }
    }
}
