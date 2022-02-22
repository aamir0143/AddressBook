﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook 
{
    public class DefaultContactDetails
    {
        //Adding multiple person(UC5)
        public static void AddPersonContact(AddressBookEntry addressBook, string defaultBookName) 
        {
            addressBook.AddContactDetails("Aamir", "Reza", "Dubaili", "Purnea", "Bihar", 854330, 7975633784, "aamirreza156@gmail.com", defaultBookName);
            addressBook.AddContactDetails("Wasim", "Anwar", "Modhipur", "Rampur", "jharkand", 854331, 7761621183, "aamirreza00@gmail.com", defaultBookName);
            addressBook.AddContactDetails("Shahab", "Alam", "sec_56", "Silampur", "Delhi", 560032, 9199523544, "abc789@gmail.com", defaultBookName);
        }
    }
}