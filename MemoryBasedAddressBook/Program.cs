var AddressBook = new AddressBook();
List<Contact> CachedContacts = new List<Contact>();   

for (int i=0; i<3; i++)
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string phoneNumber = string.Empty;
    string email = string.Empty;

    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your phoneNumber: ");
    phoneNumber = Console.ReadLine();

    Console.Write("Please enter your email: ");
    email = Console.ReadLine();

    var contact = new Contact(firstName, lastName, phoneNumber, email);
    AddressBook.AddContact(contact);
    CachedContacts.Add(contact);
}


Console.WriteLine($"Printing Contacts");
AddressBook.PrintContact();
for (int i=0; i<3; i++)
{
    Console.WriteLine($"Removing Contacts" + CachedContacts[i]);
    AddressBook.RemoveContact(CachedContacts[i]);
    AddressBook.PrintContact();
}
