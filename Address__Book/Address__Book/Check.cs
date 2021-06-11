using System;
using System.Collections.Generic;
using System.Text;

namespace Address__Book
{
    public class Check
    {
        public void CheckDetails()
        {
            Console.WriteLine();
            Console.WriteLine("press 1 to view Contact list.");
            Console.WriteLine("press 2 to Add new Contact to list.");
            Console.WriteLine("press 3 to Edit Contact in list.");
            Console.WriteLine("press 4 to Delete a Contact from list.");
            Console.WriteLine("press 5 to Exit.");
        }
        public void Selection()
        {

           
            int input = Convert.ToInt32(Console.ReadLine());
            while (input > 6 || input <= 0)
            {
                Console.WriteLine("invalid input");
                Console.WriteLine("Enter a valid input ");
                CheckDetails();
                input = Convert.ToInt32(Console.ReadLine());
            }
            ContactView contactView = new ContactView();
            switch (input)
            {
                case 1:
                    contactView.ViewList();
                    CheckDetails();
                    Selection();
                    break;
                case 2:
                    contactView.AddContact();
                    Console.WriteLine($" Contacts: {ContactView.contactsList.Count}");
                    contactView.ViewList();
                    CheckDetails();
                    Selection();
                    break;
                case 3:
                    Console.WriteLine("Edit a Contact");
                    contactView.EditContact();
                    CheckDetails();
                    Selection();
                    break;
                case 4:
                    Console.WriteLine("Delete a Contact");
                    contactView.DeleteContact();
                    CheckDetails();
                    Selection();
                    break;

                case 5:
                    Console.WriteLine("Exiting you safely...");
                    Console.WriteLine("Thank you.");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}

