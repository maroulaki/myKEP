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
            string qGetUsers = "SELECT * FROM Users";
            string qGetReqs = "SELECT * FROM Requests";
            DataSet KEPds = new DataSet();
            SqlDataAdapter UserAdapter =  new SqlDataAdapter(qGetUsers, DBHandler.ConnString);
            UserAdapter.Fill(KEPds, "Users");
            SqlDataAdapter ReqAdapter = new SqlDataAdapter(qGetReqs, DBHandler.ConnString);
            ReqAdapter.Fill(KEPds, "Requests");
            dataViewUsers.DataSource = KEPds.Tables[0];
            dataViewReq.DataSource = KEPds.Tables[1];
          
        }
    }
}
