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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
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
        //Main  Method / program Entry Point
        static void Main(string[] args)
        {
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