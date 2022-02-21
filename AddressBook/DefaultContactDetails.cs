using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook 
{
    public class DefaultContactDetails
    {
        public static void AddPersonContact(AddressBookEntry addressBook)
        {
            addressBook.AddContactDetails("Aamir", "Reza", "Dubaili", "Purnea", "Bihar", 854330, 7975633784, "aamirreza156@gmail.com");
            addressBook.AddContactDetails("Wasim", "Anwar", "Modhipur", "Rampur", "Jharkhand", 854301, 776211666, "aamirreza@gmail.com");
            addressBook.AddContactDetails("Shahab", "Alam", "Sec_56", "Silampur", "Delhi", 560032, 9199523544, "abc789@gmail.com");
        }
    }
}