using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System
{
    public class AddressBook
    {
        public static List<Contact> contactList;
        public AddressBook()
        {
            contactList = new List<Contact>();
        }

        //Function to add contact to Address book
        public void AddContact(string[] d)
        {
            Contact entry = new Contact(d[0], d[1], d[2], d[3], d[4], d[5], d[6], d[7]);
            contactList.Add(entry);
            Console.WriteLine("Contact added successfully");
        }

        //Function to print contacts in Address book
        public static void PrintContact()
        {
            if (AddressBook.contactList.Count != 0)
            {
                int count = 0;
                foreach (Contact person in contactList)
                {
                    count += 1;
                    Console.WriteLine("Contact- " + count);
                    Console.WriteLine("Name      : " + person.firstName + " " + person.lastName);
                    Console.WriteLine("Address   : " + person.address + ", " + person.city + ", " + person.state + "-" + person.zipCode);
                    Console.WriteLine("Phone No. : " + person.phoneNumber);
                    Console.WriteLine("Email id  : " + person.email);
                    Console.WriteLine("-------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("There are no contacts in the address book!");
            }
        }
    }
}
