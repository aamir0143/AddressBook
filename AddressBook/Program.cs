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
            Console.WriteLine("==========Welcome To Address Book Programs==========");
            //Create Objects
            AddressBookEntry addressBook = new AddressBookEntry(); 
            while (true)
            {
                Console.WriteLine("1: Add A New Person Details" +
                                  "\n2: View Person Details" +
                                  "\n3: Exit"
                                  );
                Console.Write("Enter The Choice From Above : ");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        //Adding New Contact (UC2)
                        AddContact.PersonDetails(addressBook);
                        break;
                    case 2:
                        addressBook.ViewContact();
                        break;
                    case 3:
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