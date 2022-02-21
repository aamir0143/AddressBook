using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBookProgram
{
    public class Program
    {
        //Initializing variable
        public static int count = 0;
        public static void Main(string[] args)
        {
            //Display the welcome message
            Console.WriteLine("==========Welcome To Address Book Program==========");
            //Creating a contact with person details(UC1)
            AddressBookEntry addressBook = new AddressBookEntry();
            addressBook.AddContactDetails("Aamir", "Reza", "Dubaili", "Purnea", "Bihar", 854330, 7975633784, "aamirreza156@gmail.com");
            addressBook.ViewContact();
        }
    }
}