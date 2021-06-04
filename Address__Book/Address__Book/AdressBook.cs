﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address__Book
{
    interface IContactDetails
    {
         void ValidateContactDetails();
    }
    class Contacts : IContactDetails
    {
        //variables
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNumber;
        private string email;

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
            if (firstName != "Jones" && lastName != "Martin")
            {
                return true;
            }
            return false;
        }
        private bool ValidateAddress(string Address, string City, string State, int  ZipCode)
        {
            if (Address != "some road" && City != "goa" && State != "goa" && ZipCode != 123 )
            {
                return true;
            }
            return false;
        }
        private bool ValidateContactNumbers(long PhoneNumber, string Email)
        {
            if (PhoneNumber != 6547882683 && Email != "xyz@mail")
            {
                return true;
            }
            return false;
        }

    }

        
}
            
                

            
           
            
           
            
