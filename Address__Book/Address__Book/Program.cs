using System;

namespace Address__Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sysyem");
            Contacts contacts = new Contacts();
            contacts.FirstName = "Sairam";
            contacts.LastName = "Kadakuntla";
            contacts.PhoneNumber = 987654321;
            contacts.State = "Telangana";
            contacts.City = "Hyderabad";
            contacts.Email = "abcd@gmail.com";
            contacts.ZipCode = 500028;
            contacts.ValidateContactDetails();
            Console.WriteLine("Contact Details: ");
            Console.WriteLine("Full Name" +contacts.FirstName+"  "+ contacts.LastName);
            Console.WriteLine("Phone Number="+contacts.PhoneNumber);
            Console.WriteLine("Address ="+contacts.City+ "  " +contacts.State+ "  " +contacts.ZipCode);
            Console.WriteLine("Email Id =" + contacts.Email);
            AddContacts addContacts = new AddContacts();
            addContacts.AddContact();

           

        }
    }
}
