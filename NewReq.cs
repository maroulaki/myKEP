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
        DBHandler KEPdb;
        User user;
        public NewReq(string AT)
        {
            InitializeComponent();
            KEPdb = new DBHandler();
            user = KEPdb.FetchUser(AT);
        }

        private void newReqButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typeField.Text))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε σωστά όλα τα πεδία", "Message");
            }
            else
            {
                Request request = new Request(typeField.Text, DateTime.Now.ToString(), user.AT, KEPdb.RequestIDGen());
                KEPdb.InsertRequest(user, request);
            }
        }
    }
}
