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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void DelReq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kEP1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.kEP1DataSet.Users);
            // TODO: This line of code loads data into the 'kEP1DataSet.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.kEP1DataSet.Requests);

        }
    }
}
