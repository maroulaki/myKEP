using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKEP
{
    public class DBHandler
    {
        string ConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mtimo\\source\\repos\\myKEP\\KEP1.mdf;Integrated Security=True;Connect Timeout=30";
        
        public void test()
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            kepDB.Open();
            kepDB.Close();
        }

        //Builds a unique request ID
        public string RequestIDGen()
        {
            Random rand = new Random();
            var reqID = new StringBuilder();
            //Adding 3 random uppercase characters
            for (int i = 0; i < 3; i++)
            {
                reqID.Append((char)rand.Next(65,90));
            }
            //And 3 random digits
            for (int i = 0; i < 3; i++)
            {
                reqID.Append(rand.Next(0,10));
            }

            return reqID.ToString();
        }

        private void NewUserEntry(User user, SqlConnection conn)
        {
            string qNewUser = "INSERT INTO Users(Name, Surname, Phone, Email, DateOfBirth, Address, AT, reqNo) VALUES (@Par1, @Par2, @Par3, @Par4, @Par5, @Par6, @Par7, @Par8)";
            SqlCommand command = new SqlCommand(qNewUser, conn);
            command.CommandText = qNewUser;
            command.Parameters.AddWithValue("@Par1", user.Name);
            command.Parameters.AddWithValue("@Par2", user.Surname);
            command.Parameters.AddWithValue("@Par3", user.Phone);
            command.Parameters.AddWithValue("@Par4", user.Email);
            command.Parameters.AddWithValue("@Par5", user.DateOfBirth);
            command.Parameters.AddWithValue("@Par6", user.Address);
            command.Parameters.AddWithValue("@Par7", user.AT);
            command.Parameters.AddWithValue("@Par8", 1);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        private void NewRequestEntry(Request request, SqlConnection conn)
        {
            string qNewReq = "INSERT INTO Requests(Type, Date, AT, reqID) VALUES (@Par1, @Par2, @Par3, @Par4)";
            SqlCommand command = new SqlCommand(qNewReq, conn);
            command.CommandText = qNewReq;
            command.Parameters.AddWithValue("@Par1", request.Type);
            command.Parameters.AddWithValue("@Par2", request.Date);
            command.Parameters.AddWithValue("@Par3", request.AT);
            command.Parameters.AddWithValue("@Par4", request.reqID);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void InsertRequest(User user, Request request)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            kepDB.Open();
            NewRequestEntry(request, kepDB);    //Add new request entry
            string qSearchByAT = "SELECT reqNo FROM Users WHERE AT=@Parameter;";
            SqlCommand command = new SqlCommand(qSearchByAT, kepDB);
            command.Parameters.AddWithValue("@Parameter", user.AT);
            SqlDataReader reader = command.ExecuteReader();
            int reqNo;
            if (reader.HasRows) //User exists, just another request
            {
                if (reader.Read())
                {
                    reqNo = reader.GetInt32(0);
                    reader.Close();
                    reqNo++;
                    //Update User Entry
                    string qUpdateReqNo = "UPDATE Users SET reqNo = @Par1 WHERE AT = @Par2";
                    command.CommandText = qUpdateReqNo;
                    command.Parameters.AddWithValue("@Par1", reqNo);
                    command.Parameters.AddWithValue("@Par2", user.AT);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Η αίτηση καταχωρίστηκε με κωδικό " + request.reqID, "Message");
                }
            }
            command.Dispose();
            kepDB.Close();
        }

        public Request FetchRequest(string Code)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            string qGetReqValues = "SELECT Type,Date,AT,reqID FROM Requests WHERE reqID = @Parameter";
            kepDB.Open();
            SqlCommand command = new SqlCommand(qGetReqValues, kepDB);
            command.Parameters.AddWithValue("@Parameter", Code);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    Request request = new Request(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    return request;
                }
            }
            kepDB.Close();
            return null;
        }

        public User FetchUser(string AT)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            string qGetUserValues = "SELECT Name, Surname, Phone, Email, DateOfBirth, Address, AT FROM Users WHERE AT = @Parameter";
            kepDB.Open();
            SqlCommand command = new SqlCommand(qGetUserValues, kepDB);
            command.Parameters.AddWithValue("@Parameter", AT);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                { 
                    User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    return user;
                }
            }
            kepDB.Close();
            return null;
        }

        public bool RequestExists(string Code)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            string qSearchReqCode = "SELECT Id FROM Requests WHERE reqID = @Parameter";
            kepDB.Open();
            SqlCommand command = new SqlCommand(qSearchReqCode, kepDB);
            command.Parameters.AddWithValue("@Parameter", Code);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                kepDB.Close();
                return true;
            }
            kepDB.Close();
            return false;
        }

        public bool UserExists(string AT)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            string qSearchByAT = "SELECT Id FROM Users WHERE AT = @Parameter";
            kepDB.Open();
            SqlCommand command = new SqlCommand(qSearchByAT, kepDB);
            command.Parameters.AddWithValue("@Parameter", AT);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                kepDB.Close();
                return true;
            }
            kepDB.Close();
            return false;
        }

        public void UpdateUser(User user)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            string qUpdateUser = "UPDATE Users SET Name = @Par1, Surname = @Par2, Phone = @Par3, Email = @Par4, DateOfBirth = @Par5, Address = @Par6 WHERE AT = @Par7";
            kepDB.Open();
            SqlCommand command = new SqlCommand(qUpdateUser, kepDB);
            command.Parameters.AddWithValue("Par1", user.Name);
            command.Parameters.AddWithValue("Par2", user.Surname);
            command.Parameters.AddWithValue("Par3", user.Phone);
            command.Parameters.AddWithValue("Par4", user.Email);
            command.Parameters.AddWithValue("Par5", user.DateOfBirth);
            command.Parameters.AddWithValue("Par6", user.Address);
            command.Parameters.AddWithValue("Par7", user.AT);
            command.ExecuteNonQuery();
            command.Dispose();
            kepDB.Close();
            MessageBox.Show("Ο χρήστης με αριθμό Ταυτότητας" + user.AT + "ενημερώθηκε");
        }

        public void UpdateRequest(Request request)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            kepDB.Open();
            string qUpdateRequest = "UPDATE Requests SET Type = @Par1 WHERE AT = @Par2";
            SqlCommand command = new SqlCommand(qUpdateRequest, kepDB);
            command.Parameters.AddWithValue("@Par1", request.Type);
            command.Parameters.AddWithValue("@Par2", request.AT);
            command.ExecuteNonQuery();
            command.Dispose();
            kepDB.Close();
            MessageBox.Show("Η αίτηση " + request.reqID + " ενημερώθηκε", "Message");
        }

        public void InsertUser(User user)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            kepDB.Open();
            if (UserExists(user.AT))
            {
                MessageBox.Show("Υπάρχει ήδη χρήστης με αυτό τον Αριθμό Ταυτότητας. Προσπαθήστε ξανά με άλλον αριθμό", "Message");
                
            } else
            {
                NewUserEntry(user, kepDB);
                MessageBox.Show("Ο χρήστης με αριθμό Ταυτότητας" + user.AT + "καταχωρίστηκε");
            }
        }

        public void DeleteUser(string AT)
        {
            SqlConnection kepDB = new SqlConnection(ConnString);
            kepDB.Open();
            string qDelUser = "DELETE FROM Users WHERE AT=@Parameter";
            SqlCommand command = new SqlCommand(qDelUser, kepDB);
            command.Parameters.AddWithValue("@Parameter", AT);
            command.ExecuteNonQuery();
            string qDelReqs = "DELETE FROM Requests WHERE AT=@Parameter";
            command.CommandText = qDelReqs;
            command.ExecuteNonQuery();
            MessageBox.Show("Ο χρήστης με Αριθμό Ταυτότητας " + AT + " έχει διαγραφεί", "Message");
        }
        

    }

}
