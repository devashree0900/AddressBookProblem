using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        private List<Contact> contactList;
        public Dictionary<string, Contact> contactDictionary;

        public AddressBook() {
            contactList = new List<Contact>();
            contactDictionary = new Dictionary<string, Contact>();
        }

        public void AddressBookFunction()
        {
            Console.WriteLine("Welcome to the Address Book");
            int num;
            do
            {
                Console.WriteLine("Enter 1 to Add New Contact, 2 to edit an existing contact and 3 to delete an existing cpontact and 0 to exit");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 1) addContact();
                else if (num == 2) editContact();
                else if (num == 3) deleteContact();
            }
            while (num != 0);
        }
        public void addContact()
        {
            Console.WriteLine("Enter your First name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            var address = Console.ReadLine();
            Console.WriteLine("Enter your City name:");
            var city = Console.ReadLine();
            Console.WriteLine("Enter your State:");
            var state = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode:");
            var zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number:");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email:");
            var email = Console.ReadLine();

            Contact person = new Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            contactList.Add(person);
            contactDictionary?.Add(firstName,person);

            Console.WriteLine("Contact added successfully");
        }

        public void editContact()
        {
            Console.WriteLine("Enter your first name to edit the contact");
            string name = Console.ReadLine();
            if(contactDictionary.ContainsKey(name))
            {
                Console.WriteLine("Contact found!");
                Console.WriteLine("Please Enter your details again to edit your contact");
                contactList.Remove(contactDictionary[name]);
                addContact();
            }
            else
            {
                Console.WriteLine("There is no contact present with the specified first name");
            }
        }

        public void deleteContact()
        {
            Console.WriteLine("Enter your first name to delete the contact");
            string name = Console.ReadLine();
            if (contactDictionary.ContainsKey(name))
            {
                Console.WriteLine("Contact found!");
                contactList.Remove(contactDictionary[name]);
                Console.WriteLine("Contact deleted Successfully");
            }
            else
            {
                Console.WriteLine("There is no contact present with the specified first name");
            }
        }

    }
}
