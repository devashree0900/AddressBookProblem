using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipcode;
        private string phoneNumber;
        private string email;

 

        public Contact(string firstName, string lastName, string address, string city, string state, string zipcode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void display(Contact contact)
        {
            Console.WriteLine("First Name: " + contact.firstName + " Last Name: " + contact.lastName + " Address: " + contact.address + " City: " + contact.city + " State: " + contact.state + " Zipcode: " + contact.zipcode + " Phone number: " + contact.phoneNumber + " Email: " + contact.email);
        }

        public string getCity(Contact contact)
        {
            return this.city;
        }

        public string getState(Contact contact)
        {
            return this.state;
        }
    }
}
