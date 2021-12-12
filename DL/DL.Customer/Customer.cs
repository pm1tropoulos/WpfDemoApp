using System;

namespace DL.Customer
{
    public class Customer
    {
        //private readonly string _firstName;
        //private readonly string _lastName;
        //private readonly string _email;
        //private readonly DateTime _birthDate;
        //private readonly int _ID;

        //public Customer(string firstName, string lastName, string email,
        //    DateTime birthDate, int ID)
        //{
        //    _firstName = firstName;
        //    _lastName = lastName;
        //    _email = email;
        //    _birthDate = birthDate;
        //    _ID = ID;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string email { get; set; }
        public int ID { get; set; }

    }
}
