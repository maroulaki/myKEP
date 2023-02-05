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
    public partial class EditReq : Form
    {
        public EditReq(string reqCode)
        {
            InitializeComponent();
            KEPdb = new DBHandler();
            request = KEPdb.FetchRequest(reqCode);
            typeField.Text = request.Type;
        }

        private DBHandler KEPdb;
        private User user;
        private Request request;

        private void reqEditButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(typeField.Text))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε σωστά όλα τα πεδία", "Message");
            }
            else
            {
                request.Type = typeField.Text;
                KEPdb.UpdateRequest(request); 
            }
        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
