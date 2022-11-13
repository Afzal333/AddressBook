using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        public void CreateContact()
        {

            Console.WriteLine("Address Book");            
            Console.WriteLine("Enter FirstName :");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName :");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP :");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber :");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            contact.Email = Console.ReadLine();
            Display();    
        }

        public void EditContact(string name)
        {
            if(contact.FirstName.Equals(name) || contact.LastName.Equals(name))
            {
                Console.WriteLine("1. Address \n 2.City \n 3. State \n 4.Zip \n 5.Phone number");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:contact.Address = Console.ReadLine(); Display(); break;
                    case 2:contact.City = Console.ReadLine(); Display(); break;
                    case 3:contact.State = Console.ReadLine(); Display(); break;
                    case 4:contact.Zip =Convert.ToInt32(Console.ReadLine()); Display(); break;
                    case 5:contact.PhoneNumber = Console.ReadLine(); Display(); break;

                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n" +
               contact.FirstName + "\n" +
               contact.LastName + "\n" +
               contact.Address + "\n" +
               contact.City + "\n" +
               contact.State + "\n" +
               contact.Zip + "\n" +
               contact.PhoneNumber + "\n" +
               contact.Email);

        }
    }
}
