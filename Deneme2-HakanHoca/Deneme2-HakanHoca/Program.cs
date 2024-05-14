
using Deneme2_HakanHoca;

List<Person> people = new()
{
    new Person()
    {
     Name = "Sena",
     Surname = "Taşçı",
     PhoneNumber = "123456",

    },

    new Person()
    {
     Name = "Müberra",
     Surname = "Kaya",
     PhoneNumber = "789456",

    }

};

void PrintMenu()
{
    Console.WriteLine("1 - List People");
    Console.WriteLine("2 - Add Person");
    Console.WriteLine("3 - Remove Person");
    Console.WriteLine("4 - Update Person");
}


string ReadConsoleWithMessage(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();

}


void PrintPeople()
{
    foreach (var person in people)
        Console.WriteLine($"{person.Name}-{person.Surname}-{person.PhoneNumber}");
}



void AddPerson()
{
    string name = ReadConsoleWithMessage("Please enter a name: ");
    string surname = ReadConsoleWithMessage("Please enter a surname: ");
    string phoneNumber = ReadConsoleWithMessage("Please enter a phone number: ");

    Person person = new()
    {
        Name = name,
        Surname = surname,
        PhoneNumber = phoneNumber,
    };

    people.Add(person);
    Console.WriteLine($"{name} is saved !");

}


void DeletePerson()
{
    string phoneNumber = ReadConsoleWithMessage("Please enter a phone number: ");
    string name = "";

    foreach (var person in people)
    {
        if (person.PhoneNumber == phoneNumber)
        {
            name = person.Name;
            people.Remove(person);
            return;
        }

        Console.WriteLine($"{name} is deleted.");

    }

}



void UpdatePerson()
{
    string phoneNumber = ReadConsoleWithMessage("Please enter a phone number: ");
    int index = -1;

    for (int i = 0; i < people.Count; i++)
    {
        if (people[i].PhoneNumber == phoneNumber)
        {
            index = i;
            break;
        }


    }

    if (index == -1)
    {
        Console.WriteLine("Person not found !");
        return;

    }

    string nameUpdated = ReadConsoleWithMessage("Please enter a name updated version: ");
    string surnameUpdated = ReadConsoleWithMessage("Please enter a surname updated version: ");
    string phoneNumberUpdated = ReadConsoleWithMessage("Please enter a phone number updated version: ");

    string oldname = people[index].Name;

    people[index].Name = nameUpdated;
    people[index].Surname = surnameUpdated;
    people[index].PhoneNumber = phoneNumberUpdated;

    Console.WriteLine($"{oldname} is uplated to {nameUpdated}");
    Console.WriteLine();
}



while (true)
{
    PrintMenu();

    string selection = ReadConsoleWithMessage("Enter a selection");

    if (selection == "1")
        PrintPeople();

    else if (selection == "2")
        AddPerson();

    else if (selection == "3")
        DeletePerson();

    else if (selection == "4")
        UpdatePerson();
}


