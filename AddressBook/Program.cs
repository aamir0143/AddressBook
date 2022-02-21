using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Display the Welcome Message
            Console.WriteLine("==========Welcome To Address Book Program==========");
            //Create objects
            AddressBookEntry addressBook = new AddressBookEntry(); 
            while (true)
            {
                Console.WriteLine("1: Add A New Person Details" +
                                  "\n2: Add Default Contact Details" +
                                  "\n3: View Person Details" +
                                  "\n4: Edit Person Details" +
                                  "\n4: Exit"
                                  );
                Console.Write("Enter The Choice From Above : ");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        //Creating a new contact with person details(UC2) 
                        AddContact.PersonDetails(addressBook);
                        break;
                    case 2:
                        //Creating a contact with person details(UC1) 
                        DefaultContactDetails.AddPersonContact(addressBook);
                        break;
                    case 3:
                        addressBook.ViewContact();
                        break;
                    case 4:
                        //Editing a contact details with given name(UC3)
                        Console.Write("Enter The First Name Exactly To Edit : ");
                        string fName = Console.ReadLine();
                        addressBook.EditContact(fName);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A Right Choice");
                        continue;
                }
            }
        }
    }
}