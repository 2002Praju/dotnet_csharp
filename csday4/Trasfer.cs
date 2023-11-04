using System;
using System.Collections.Generic;

// Define the Contact class to represent an individual contact
class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string firstName, string lastName, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}\nPhone: {PhoneNumber}\nEmail: {Email}";
    }
}

// Define the ContactBook class to manage contacts
class ContactBook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public List<Contact> GetContacts()
    {
        return contacts;
    }

    public Contact FindContactByName(string firstName, string lastName)
    {
        return contacts.Find(contact => contact.FirstName == firstName && contact.LastName == lastName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactBook contactBook = new ContactBook();

        // Adding contacts
        Contact contact1 = new Contact("John", "Doe", "123-456-7890", "john.doe@email.com");
        Contact contact2 = new Contact("Jane", "Smith", "987-654-3210", "jane.smith@email.com");

        contactBook.AddContact(contact1);
        contactBook.AddContact(contact2);

        // Searching for a contact by name
        string searchFirstName = "John";
        string searchLastName = "Doe";
        Contact foundContact = contactBook.FindContactByName(searchFirstName, searchLastName);

        if (foundContact != null)
        {
            Console.WriteLine("Contact found:");
            Console.WriteLine(foundContact);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
