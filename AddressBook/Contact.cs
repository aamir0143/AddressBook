using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    public class Contact
    {
<<<<<<< HEAD
        // variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zipCode;
        public long phoneNumber;
        public string email;
<<<<<<< HEAD
        //// constructor that gets user detail and store it in the current object.
=======
        // constructor that gets user detail and store it in the current object.
>>>>>>> UC3_EditContacts
        public Contact(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email)
=======
        //Declaring contact details properties
        public readonly string firstName;
        public readonly string lastName;
        public readonly string address;
        public readonly string city;
        public readonly string state;
        public readonly int zip;
        public readonly long phoneNumber;
        public readonly string emailId;
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId)
>>>>>>> UC1_CreateContact
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
<<<<<<< HEAD
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        /// <summary>
        /// To display the contact details.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("First Name:{0}", this.firstName);
            Console.WriteLine("Last Name:{0}", this.lastName);
            Console.WriteLine("Address:{0}", this.address);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("State:{0}", this.state);
            Console.WriteLine("Zipcode:{0}", this.zipCode);
            Console.WriteLine("phone number:{0}", this.phoneNumber);
            Console.WriteLine("Email:{0}", this.email);
=======
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
>>>>>>> UC1_CreateContact
        }
    }
}