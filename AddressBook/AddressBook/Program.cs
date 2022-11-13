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
                                  "2. Edit Contact"+"\n" );
                int options = Convert.ToInt32(Console.ReadLine());
                AddressBookMain addressBookMain = new AddressBookMain();
                switch (options)
                {
                    case 1:
                        addressBookMain.CreateContact(); 
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contct name");
                        string name=Console.ReadLine();
                        addressBookMain.EditContact(name);
                        break;

                }
               

            }
           
           
        }
    }
}
