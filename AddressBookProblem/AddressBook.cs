using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{

    public class AddressBookRecord
    {
        public List<AddressBook> records;
        public Dictionary<string, AddressBook>  AddressBookDictionary;
        

        public AddressBookRecord()
        { 
            records = new List<AddressBook>();
            AddressBookDictionary= new Dictionary<string, AddressBook>();
           
        }
        public void AddressBookRecordFunction(AddressBookRecord obj)
        {
            Console.WriteLine("Welcome to the Address Book Record");
            int num;
            do
            {
                Console.WriteLine("Enter 1 to Add New Address Book and 0 to exit");
                num = Convert.ToInt32(Console.ReadLine()); 
                if (num == 1)
                {
                    
                    Console.WriteLine("Enter the name of your Address Book");
                    var name = Console.ReadLine();
                    AddressBook addressbook = new AddressBook(name);
                    AddressBookDictionary?.Add(name, addressbook);
                    records.Add(addressbook);
                    Console.WriteLine("Address Book Added Successfully");
                    addressbook.AddressBookFunction(obj);

                }
                
            }
            while (num != 0);
        }

        
    }
    public class AddressBook
    {
        public List<Contact> contactList;
        public Dictionary<string, Contact> contactDictionary;
        
        private string addressBookName;

        public AddressBook(string name) {
            contactList = new List<Contact>();
            contactDictionary = new Dictionary<string, Contact>();
            this.addressBookName = name;
        }

        public void AddressBookFunction(AddressBookRecord obj)
        {
            Console.WriteLine("Welcome to the Address Book named: " + this.addressBookName);
            int num;
            do
            {
                Console.WriteLine("Enter 1 to Add New Contact, 2 to edit an existing contact and 3 to delete an existing contact, 4 to display all the contacts, 5 to display all contacts living in a city across all books, 6 to display all contacts living in a state across all books, 7 to count all persons by city name, 8 to count all persons by state name and 0 to exit");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 1) addContact(obj);
                else if (num == 2) editContact(obj);
                else if (num == 3) deleteContact(obj);
                else if (num == 4) displayContact(obj);
                else if (num == 5) SearchPersonByCity(obj);
                else if (num == 6) SearchPersonByState(obj);
                else if(num == 7) CountPersonByCity(obj);
                else if(num == 8) CountPersonByState(obj) ;
            }
            while (num != 0);
        }

        public void SearchPersonByCity(AddressBookRecord obj)
        {
            Console.WriteLine("Enter the city name: ");
            var city = Console.ReadLine();
            foreach (var rec in obj.records)
            {

                //foreach (Contact val in rec.contactList)
                //{
                //    if (val.getCity(val) == city)
                //    {

                //        val.display(val);
                //    }
                //}
               
                var result = rec.contactList.FindAll(x => x.getCity(x) == city);
                foreach (Contact con in result)
                {
                    con.display(con);
                }

            }
        }

        public void CountPersonByCity(AddressBookRecord obj)
        {
            Console.WriteLine("Enter the city name: ");
            var city = Console.ReadLine();
            foreach (var rec in obj.records)
            {

                var result = rec.contactList.Count(x => x.getCity(x) == city);
                Console.WriteLine("The number of records with city name " + city + " is : " + result);

            }
        }

        public void CountPersonByState(AddressBookRecord obj)
        {
            Console.WriteLine("Enter the city name: ");
            var state = Console.ReadLine();
            foreach (var rec in obj.records)
            {

                var result = rec.contactList.Count(x => x.getState(x) == state);
                Console.WriteLine("The number of records with city name " + state + " is : " + result);

            }
        }
        public void SearchPersonByState(AddressBookRecord obj)
        {
            Console.WriteLine("Enter the state name: ");
            var state = Console.ReadLine();
            foreach (var rec in obj.records)
            {

                foreach (Contact val in rec.contactList)
                {
                    if (val.getState(val) == state)
                    {

                        val.display(val);
                    }
                }
            }
        }

        
        public void addContact(AddressBookRecord obj)
        {
            Console.WriteLine("Enter your First name:");
            var firstName = Console.ReadLine();


            if(contactDictionary.ContainsKey(firstName)) 
            {
                Console.WriteLine("Contact with this firstname is already present, try with another entry with any other name");
                return;
            }


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
            contactDictionary?.Add(firstName, person);

            Console.WriteLine("Contact added successfully");
        }

        public void editContact(AddressBookRecord obj)
        {
            Console.WriteLine("Enter your first name to edit the contact");
            string name = Console.ReadLine();
            if (contactDictionary.ContainsKey(name))
            {
                Console.WriteLine("Contact found!");
                Console.WriteLine("Please Enter your details again to edit your contact");
                contactList.Remove(contactDictionary[name]);
                addContact(obj);
            }
            else
            {
                Console.WriteLine("There is no contact present with the specified first name");
            }
        }

        public void deleteContact(AddressBookRecord obj)
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

        public void displayContact(AddressBookRecord obj)
        {
            foreach (var item in contactDictionary)
            {
                Contact c = item.Value;
                c.display(c);
            }
        }

    }
}
