
using GuestBookTestLibrary;
using GuestBookTestLibrary.Models;


List<PersonModel> guestList = new List<PersonModel>();

GenerateGuestList(guestList);

foreach (PersonModel guest in guestList)
{
    Console.WriteLine($"{guest.FirstName} {guest.LastName} {guest.MessageToHost}");
}




Console.ReadLine();

static void GenerateGuestList(List<PersonModel> guestList)
{
    string anotherGuest = "";

    do
    {
        PersonModel person = new PersonModel();


        Console.Write("What is your first name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        person.LastName = Console.ReadLine();

        Console.Write("What is your message to the host: ");
        person.MessageToHost = Console.ReadLine();

        Console.Write("Is there another guest (yes/no): ");
        anotherGuest = Console.ReadLine();

        guestList.Add(person);

    } while (anotherGuest.ToLower() != "no");
}