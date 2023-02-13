using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        
        private void View_Load(object sender, EventArgs e)

        {
            DBHandler kepDB = new DBHandler();
            string qGetUsers = "SELECT * FROM Users";
            string qGetReqs = "SELECT * FROM Requests";
            DataSet KEPds = new DataSet();
            KEPds.Tables.Clear();
            SqlDataAdapter UserAdapter =  new SqlDataAdapter(qGetUsers, kepDB.ConnString);
            UserAdapter.Fill(KEPds, "Users");
            SqlDataAdapter ReqAdapter = new SqlDataAdapter(qGetReqs, kepDB.ConnString);
            ReqAdapter.Fill(KEPds, "Requests");
            dataViewUsers.DataSource = KEPds.Tables[0];
            dataViewReq.DataSource = KEPds.Tables[1];

            //this.KEP1DataSet.Requests.Clear();
            //this.KEP1DataSet.Users.Clear();
            //// TODO: This line of code loads data into the 'KEP1DataSet.Requests' table. You can move, or remove it, as needed.
            //this.requestsTableAdapter.Fill(this.KEP1DataSet.Requests);
            //// TODO: This line of code loads data into the 'KEP1DataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.KEP1DataSet.Users);
            
            
        }
    }
}
