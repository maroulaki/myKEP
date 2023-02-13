namespace myKEP
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AT { get; set; }
        
        

        public User (string name, string surname, string phone, string email, string dob, string address, string ID)
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
