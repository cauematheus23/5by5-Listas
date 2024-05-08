using _5by5_Listass;
using System.Security.Cryptography.X509Certificates;


string path = @"C:\Contacts\";
string file = "ContactList.txt";



List<Person> persons = new List<Person>();
void Menu()
{
    Console.WriteLine(">>>>> MENU CONTACT LIST <<<<<");
    Console.WriteLine();
    Console.WriteLine("[1] - Insert person in Contact list ");
    Console.WriteLine("[2] - Print Contact list ");
    Console.WriteLine("[3] - Print File Contact list ");
    Console.WriteLine("[4] - Remove from Contact list ");
    Console.WriteLine("[5] - EXIT");
}

bool CheckIfExists(string p,string f)
{
    if (!Directory.Exists(p))
    {
        Directory.CreateDirectory(p);
    }
    if (!File.Exists(p + f))
    {
        File.Create(p + f);
    }

    return true;
}


void CreateContactList(List<Person> personslist,string p, string f)
{
   
    if (CheckIfExists(p, f))
    {
        StreamWriter sw = new(p + f);
        foreach(Person person in personslist) 
        {
            sw.WriteLine(person.ToString());
        }
        sw.Close();
    }
}
void LoadContactList( string p, string f)
{ 
    if(CheckIfExists(p, f))
    {
        StreamReader sr = new StreamReader(p + f);
        foreach( var line in sr.ReadToEnd())
        {
            Console.Write(line);
            
        }
        sr.Close();
    }
}
void RemoveByname(List<Person> persons,string p , string f)
{
    Console.WriteLine("Type the name you want remove");
    string nameToRemove = Console.ReadLine().ToLower();
    List<Person> personsToRemove = new List<Person>();
    foreach (var person in persons)
    {
        if (person.GetName().ToLower() == nameToRemove)
        {
            personsToRemove.Add(person);
        }
    }
    foreach (var personToRemove in personsToRemove)
    {
        persons.Remove(personToRemove);
    }
    CreateContactList(persons, p, f);
}

Adress SetAdress()
{
    Adress adress = new Adress();
    Console.WriteLine("Write cep: ");
    adress.SetCep(Console.ReadLine());
    Console.WriteLine("Write city: ");
    adress.SetCity(Console.ReadLine());
    Console.WriteLine("Write UF: ");
    adress.SetUF(Console.ReadLine());
    Console.WriteLine("Write street: ");
    adress.SetStreet(Console.ReadLine());
    Console.WriteLine("Write street type: ");
    adress.SetStreetType(Console.ReadLine());
    Console.WriteLine("Write district: ");
    adress.SetDistrict(Console.ReadLine());
    Console.WriteLine("Write number: ");
    adress.SetNumber(int.Parse(Console.ReadLine()));
    Console.WriteLine("Write complement: ");
    adress.setComplement(Console.ReadLine());

    return adress;
}

Person CreatePerson()
{
    string name, email;
    Console.WriteLine("Type your name: ");
    name = Console.ReadLine();
    Console.WriteLine("Type your email: ");
    email = Console.ReadLine();
    Person person = new Person(name, email/*, SetAdress()*/);
    string answer = "";
    do
    {
        Console.WriteLine("Do you want add a phone number ? y or n");
        answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            Console.WriteLine("Type your number phone");
            person.AddPhone(new(Console.ReadLine()));

        }

    } while (answer == "y");


            return person;
}

void ShowAll(List<Person> list)
{
    foreach (Person person in list)
    {
        Console.WriteLine(person.ToString());
    }

}


do
{
    Menu();
    int o = int.Parse(Console.ReadLine());
    switch (o)
    {
        case 1:
            persons.Add(CreatePerson());
            CreateContactList(persons, path, file);
            break;
        case 2:
            ShowAll(persons);
            break;
        case 3:
            LoadContactList(path, file);
            break;
        case 4:
            RemoveByname(persons, path,file);
            break;
        case 5:
            Environment.Exit(0);
            break;
    }
    Console.WriteLine("Press ENTER to continue");
    Console.ReadKey();
    Console.Clear();
} while (true);









//Person caue = new("Cauê", "cauematheus_23@hotmail.com", new("14807040", "Araraquara", "SP", "Doutor adhemar", "Avenida", "Melhado", 54, "casa 55"));
//caue.AddPhone(new("101010"));
//caue.AddPhone(new("9999999"));
//caue.AddPhone(new("54894849"));
//Console.WriteLine(caue.ToString()); 
//PersonList contactList = new PersonList();




//contactList.Add(Person caue = new Person("Ana", "Ana@hotmail.com", new("14807040", "Sergipe", "SP", "Doutor adhemar", "Avenida", "Melhado", 54, "casa 55"), new()));
//contactList.Add(new("Ana" , "Ana@hotmail.com", new("14807040" , "Sergipe" , "SP", "Doutor adhemar" , "Avenida", "Melhado", 54 , "casa 55"),new()));
//contactList.getName();




//ContactList l1 = new ContactList();

//Contact contact = new("Bernardo", "123");
//l1.Add(contact);
//Contact contact1 = new("Ana", "456");
//l1.Add(contact1);
//Contact contact2 = new("Caue", "789");
//l1.Add(contact2);
//l1.RemoveByName("Bernardo");
