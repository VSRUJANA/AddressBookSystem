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
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("There are no contacts in the address book!");
            }
        }
        public static Contact FindContact(string name)
        {
            Contact contact = contactList.Find((person) => person.firstName.ToUpper() == name.ToUpper());
            return contact;
        }
        public static Contact EditContact(Contact edit)
        {
            Console.WriteLine("Enter your choice : \n1. Edit all\t  2.Edit address\t  3.Edit Phone no.\t  4.Edit Email id\t  5.End editing");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter new details separated by comma in this format - Address,City,State,ZipCode,Phone Number,Email Id");
                    string[] newDetails;
                    newDetails = Console.ReadLine().Split(",");
                    edit.address = newDetails[0];
                    edit.city = newDetails[1];
                    edit.state = newDetails[2];
                    edit.zipCode = newDetails[3];
                    edit.phoneNumber = newDetails[4];
                    edit.email = newDetails[5];
                    Console.WriteLine("Details updated for {0}", edit.firstName);
                    break;
                case 2:
                    Console.WriteLine("Enter new address in this format - Address,City,State,ZipCode ");
                    string[] newAddress;
                    newAddress = Console.ReadLine().Split(",");
                    edit.address = newAddress[0];
                    edit.city = newAddress[1];
                    edit.state = newAddress[2];
                    edit.zipCode = newAddress[3];
                    Console.WriteLine("Address updated for {0}", edit.firstName);
                    break;
                case 3:
                    Console.WriteLine("Enter new Phone number");
                    string newPhoneNumber = Console.ReadLine();
                    edit.phoneNumber = newPhoneNumber;
                    Console.WriteLine("Phone Number updated for {0}", edit.firstName);
                    break;
                case 4:
                    Console.WriteLine("Enter new Email id");
                    string newEmailID = Console.ReadLine();
                    edit.email = newEmailID;
                    Console.WriteLine("Email ID updated for {0}", edit.firstName);
                    break;
                default:
                    break;
            }
            return edit;
        }
        //Function to delete a contact from address book
        public static void DeleteContact(string name)
        {
            Contact find = AddressBook.FindContact(name);
            if (find == null)
            {
                Console.WriteLine("No Record found for {0} in the address book", name);
            }
            else
            {
                contactList.Remove(find);
                Console.WriteLine("Contact Deleted successfully!");
            }

        }
    }
}
