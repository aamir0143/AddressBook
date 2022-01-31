// See https://aka.ms/new-console-template for more information
using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Addess Book Programs==========");
            AddressBookEntry addressBook = new AddressBookEntry();
            Contact newContact = addressBook.CreateContact();
            Console.WriteLine("*****-> Details Of Person  <-*****");
            Console.WriteLine($"First Name: {newContact.FirstName}");
            Console.WriteLine($"Last Name: {newContact.LastName}");
            Console.WriteLine($"City Name: {newContact.City}");
            Console.WriteLine($"State Name: {newContact.State}");
            Console.WriteLine($"Zipcode: {newContact.ZipCode}");
            Console.WriteLine($"PhoneNumber: {newContact.PhoneNumber}");
            Console.WriteLine($"Email: {newContact.Email}");
            Console.WriteLine("==========================================================================");
            Console.ReadLine();
        }
    }
}