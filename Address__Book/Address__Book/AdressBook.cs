using System;
using System.Collections.Generic;
using System.Text;

namespace Address__Book
{
    ////UC1-Creating all the contact details
    interface IContactDetails
    {
        void ValidateContactDetails();
    }
    class Contacts : IContactDetails
    {

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public void ValidateContactDetails()
        {
            bool fullName = ValidateFullName(FirstName, LastName);
            bool address = ValidateAddress(Address, City, State, ZipCode);
            bool contact = ValidateContactNumbers(PhoneNumber, Email);
            if (fullName == true && address == true && contact == true)
            {
                Console.WriteLine("contact saved succesfully");
            }
            else
                Console.WriteLine("error in saving contact");

        }
        private bool ValidateFullName(string firstName, string lastName)
        {
            if (firstName != " " && lastName != " ")
            {
                return true;
            }
            return false;
        }
        private bool ValidateAddress(string Address, string City, string State, int ZipCode)
        {
            if (Address != " " && City != " " && State != " " && ZipCode != 123)
            {
                return true;
            }
            return false;
        }
        private bool ValidateContactNumbers(long PhoneNumber, string Email)
        {
            if (PhoneNumber != 36558687 && Email != " ")
            {
                return true;
            }
            return false;
        }

    }
 
}


        
            
                

            
           
            
           
            
