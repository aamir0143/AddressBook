<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using AddressBook;
Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n3)DeleteContact\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new CreateNewContact().Show();
        break;
    case 2:
        EditEntry.NewContact();
        EditEntry.ListAllContacts();
        EditEntry.Update();
        break;
    case 3:
        DeleteContact.NewContact();
        DeleteContact.ListAllContacts();
        DeleteContact.Delete();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;
=======
=======
>>>>>>> UC2_AddNewContact
﻿using System;
=======
﻿using AddressBook;
using System;
>>>>>>> UC1_CreateContact
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBookProgram
{
    public class Program
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    class Program
>>>>>>> UC4_DeletePerson
    {
        //Initializing variable
        public static int count = 0;
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            //Showing Welcome Message On console.
<<<<<<< HEAD
            Console.WriteLine("==========Welcome To Addess Book Programs==========");
            Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
            AddressBookEntry addressBook = new AddressBookEntry()  //Initializing elements using collection-initializer syntax
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
<<<<<<< HEAD
            addressBook.displayContact();
=======
            addressBook.DisplayContact();
            addressBook.AddContact();
>>>>>>> UC2_AddNewContact
            Console.ReadLine();
=======
            //Display the welcome message
            Console.WriteLine("==========Welcome To Address Book Program==========");
            //Creating a contact with person details(UC1)
            AddressBookEntry addressBook = new AddressBookEntry();
            addressBook.AddContactDetails("Aamir", "Reza", "Dubaili", "Purnea", "Bihar", 854330, 7975633784, "aamirreza156@gmail.com");
            addressBook.ViewContact();
>>>>>>> UC1_CreateContact
        }
    }
>>>>>>> UC1_CreateContact
=======
            Console.WriteLine("==========Welcome to Address Book Programs==========");
            AddressBook createAddressBook = new AddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();

        }
    }
>>>>>>> UC4_DeletePerson
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    class Program
    {
        //Main  Method for program Entry Point
        static void Main(string[] args)
        {
            //Showing Welcome Message On console.
            Console.WriteLine("==========Welcome To Address Book Programs==========");
            AddressBook createAddressBook = new AddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
>>>>>>> UC3_EditContacts
}