namespace myKEP
{
    public class usersDB
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AT { get; set; }
        
        

        public usersDB (string name, string surname, string email, string phone, string dob, string address, string ID)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DateOfBirth = dob;
            Address = address;
            AT = ID;
        }

    }
}
