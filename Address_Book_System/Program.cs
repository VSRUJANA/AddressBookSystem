using System;
using System.Collections.Generic;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            bool var = true;
            var AB = new AddressBook();
            while (var)
            {
                Console.WriteLine("Enter your choice :\n1.Add Contact\n2.Edit contact\n3.Print Address Book\n4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter details separated by comma in this format - First Name,Last Name,Address,City,State,ZipCode,Phone Number,Email");
                        string[] details;
                        details = Console.ReadLine().Split(",");
                        AB.AddContact(details);
                        break;
                    case 2:
                        Console.WriteLine("Enter Name to Edit: ");
                        string name = Console.ReadLine();
                        Contact find = AddressBook.FindContact(name);
                        if (find == null)
                        {
                            Console.WriteLine("No Record found for {0}", name);
                        }
                        else
                        {
                            AddressBook.EditContact(find);
                        }
                        break;
                    case 3:
                        AddressBook.PrintContact();
                        break;
                    default:
                        var = false;
                        Console.WriteLine("press any key to exit....");
                        break;
                }
            }
        }
    }
}
