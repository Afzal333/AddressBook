﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookMain
    {
        public void CreateContact()
        {

            Console.WriteLine("Address Book");
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt64(Console.ReadLine()),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
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