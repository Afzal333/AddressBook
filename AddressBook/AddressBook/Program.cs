using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            AddressBookMain addressBookMain = new AddressBookMain();
            while (flag = true)
            {
                Console.WriteLine("AddressBook");
                Console.WriteLine("Enter the Option");
                Console.WriteLine("1. Create Contact "+"\n"+
                                  "2. Edit Contact"+"\n" +
                                  "3. Delete"+"\n" +
                                  "4. Display all Contacts"+"\n" +
                                  "5. Create Dictionay"+"\n" +
                                  "6. Display Dictionary");
                int options = Convert.ToInt32(Console.ReadLine());
                
                
                switch (options)
                {
                    case 1:                        
                        addressBookMain.CreateContact(); 
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact name to Edit");
                        string name=Console.ReadLine();                    
                        addressBookMain.EditContact(name);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact name to Delete");
                        string name2 = Console.ReadLine();                      
                        addressBookMain.DeleteContact(name2);
                        break;
                    case 4:                      
                        addressBookMain.Display();
                        break;
                    case 5:                        
                        addressBookMain.CreateDictionaryContact();
                        break ;
                    case 6:                        
                        addressBookMain.DisplayDictionary();
                        break;
                    default:
                        flag= false;
                        break;
                }
            }
        }
    }
}
