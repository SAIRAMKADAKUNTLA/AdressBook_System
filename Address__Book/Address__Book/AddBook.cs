using System;
using System.Collections.Generic;
using System.Text;

namespace Address__Book
{
    interface AddBook
    {
        public void MakingList();
        public void ViewList();
        public void AddContact();
        public void DeleteContact();
        public void EditContact();
    }
    class ContactView : AddBook
    {
        public static List<Contacts> contactsList = new List<Contacts>();
        public Contacts contact3 = new Contacts();
        public void MakingList()
        {
            Contacts contact1 = new Contacts
            {
                FirstName = "James",
                LastName = "Martin",
                Address = "Jamong",
                City = "Kerala",
                State = "Kerala",
                ZipCode = 548622,
                PhoneNumber = 123456789,
                Email = "James@mail.com"
            };
            Contacts contact2 = new Contacts
            {
                FirstName = "Martin",
                LastName = "Guptil",
                Address = "Jambo",
                City = "Mumbai",
                State = "Maharastra",
                ZipCode = 478945,
                PhoneNumber = 4587963215,
                Email = "Martin@mail.com"
            };
            contact1.ValidateContactDetails();
            contact2.ValidateContactDetails();          
            contactsList.Add(contact1);
            contactsList.Add(contact2);
        }
 
        public void ViewList()
        {
            if (contactsList.Count == 0)
                Console.WriteLine("No Contacts to Display");
            else
            {
                foreach (Contacts i in contactsList)
                {
                    Console.WriteLine();
                    Console.WriteLine("Contacts");
                    Console.WriteLine($"Full Name:" + (i.FirstName) + (i.LastName));
                    Console.WriteLine($"Phone Number:" + i.PhoneNumber);
                    Console.WriteLine($"Email:" + i.Email);
                    Console.WriteLine($"Address:" + i.Address + i.City + i.State + i.ZipCode);
                }
            }

        }

        public void AddContact()
        {
            CustomInput(contact3);
            //validating contact details
            contact3.ValidateContactDetails();
            //adding contact to list
            contactsList.Add(contact3);

        }
 
        public void DeleteContact()
        {
            if (contactsList.Count == 0)
            {
                Console.WriteLine("No Contacts available to Delete");
            }
            else
            {
                int i = 0;
                Console.WriteLine("Select the contact you want to Delete : ");
                foreach (Contacts contacts in ContactView.contactsList)
                {
                    Console.WriteLine($" press {i} for {contacts.FirstName}");
                    i++;
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                while (choice >= i || choice < 0)
                {
                    Console.WriteLine("invalid choice made,");
                    Console.WriteLine("enter a valid choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                contactsList.RemoveAt(choice);
                Console.WriteLine("Contact deleted successfully!!");
            }
        }

        public void EditContact()
        {
            if (contactsList.Count == 0)
            {
                Console.WriteLine("No Contacts available to Edit");
            }
            else
            {
                int i = 0;
                Console.WriteLine("Select the contact you want to Edit : ");
                foreach (Contacts contacts in ContactView.contactsList)
                {

                    Console.WriteLine($" press" +i +"for"+ (contacts.FirstName));
                    i++;
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                while (choice >= i || choice < 0)
                {
                    Console.WriteLine("invalid choice made,");
                    Console.WriteLine("enter a valid choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("-------Before editing-------");
                CustomView(choice);
                Console.WriteLine("Enter new Details");
                CustomInput(contact3);
                contact3.ValidateContactDetails();
                contactsList.RemoveAt(choice);
                contactsList.Insert(choice, contact3);
                Console.WriteLine();
                Console.WriteLine("Contact edit successful!!");
                Console.WriteLine("-------After editing-------");
                CustomView(choice);
            }
        }

        private void CustomView(int choice)
        {
            Console.WriteLine();
            Console.WriteLine("Contacts");
            Console.WriteLine($"Full Name:"+contactsList[choice].FirstName+ contactsList[choice].LastName);
            Console.WriteLine($"Phone Number:" +contactsList[choice].PhoneNumber);
            Console.WriteLine($"Email:"+ contactsList[choice].Email);
            Console.WriteLine($"Address:" +contactsList[choice].Address+contactsList[choice].City+contactsList[choice].State+contactsList[choice].ZipCode);
            Console.WriteLine();
        }

        public void CustomInput(Contacts Person)
        {
            Console.WriteLine("Add a new contact.");
            Console.WriteLine("Enter First Name: ");
            Person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            Person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Person.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            Person.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            Person.State = Console.ReadLine();
            Console.WriteLine("Enter ZipCode: ");
            var input = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine("invalid Input!! try again.");
                    input = Console.ReadLine();
                }
                else
                {
                    Person.ZipCode = Convert.ToInt32(input);
                    break;
                }
            }
            Console.WriteLine("Enter Phone Number: ");
            input = Console.ReadLine();
            while (true)
            {
                if (Int64.TryParse(input, out _))
                {
                    Person.PhoneNumber = Convert.ToInt64(input);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid Input!! try again.");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter Email: ");
            Person.Email = Console.ReadLine();
        }
    }
}
