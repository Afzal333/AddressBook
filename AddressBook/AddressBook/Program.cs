using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag = true)
            {
                Console.WriteLine("AddressBook");
                Console.WriteLine("Enter the Option");
                Console.WriteLine("1. Create Contact "+"\n"+
                                  "2. Edit Contact"+"\n" +
                                  "3. Delete"+"\n" +
                                  "4. Display all Contacts");
                int options = Convert.ToInt32(Console.ReadLine());
                
                
                switch (options)
                {
                    case 1:
                        AddressBookMain addressBookMain = new AddressBookMain();
                        addressBookMain.CreateContact(); 
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact name to Edit");
                        string name=Console.ReadLine();
                        AddressBookMain addressBookMain2 = new AddressBookMain();
                        addressBookMain2.EditContact(name);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact name to Delete");
                        string name2 = Console.ReadLine();
                        AddressBookMain addressBookMain3 = new AddressBookMain();
                        addressBookMain3.DeleteContact(name2);
                        break;
                    case 4:
                        AddressBookMain addressBookMain4 = new AddressBookMain();
                        addressBookMain4.Display();
                        break;
                    default:
                        flag= false;
                        break;
                }
            }
        }
    }
}
