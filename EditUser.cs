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
    public partial class EditUser : Form
    {
        User user;
        DBHandler KEPdb;

        public EditUser(string AT)
        {
            InitializeComponent();
            KEPdb = new DBHandler();
            user = KEPdb.FetchUser(AT);
            nameField.Text = user.Name;
            surnameField.Text = user.Surname;
            phoneField.Text = user.Phone;
            emailField.Text = user.Email;
            dobPicker.Text = user.DateOfBirth;
            addressField.Text = user.Address;
        }

        private void newReqLabel_Click(object sender, EventArgs e)
        {

        }

        private void userEditButton_Click(object sender, EventArgs e)
        {
            bool emptyFields = false;

            if (string.IsNullOrEmpty(nameField.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(surnameField.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(phoneField.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(emailField.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(addressField.Text))
            {
                emptyFields = true;
            }
            else if (dobPicker.Value.Date >= DateTime.Today)
            {
                emptyFields = true;
            }

            if (emptyFields)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε σωστά όλα τα πεδία", "Message");
            }
            else
            {
                user.Name = nameField.Text;
                user.Surname = surnameField.Text;
                user.Phone = phoneField.Text;
                user.Email = emailField.Text;
                user.DateOfBirth = dobPicker.Text;
                user.Address = addressField.Text;
                KEPdb.UpdateUser(user);
            }
        }
    }
}
