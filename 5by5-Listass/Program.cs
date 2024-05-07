using _5by5_Listass;
using System.Security.Cryptography.X509Certificates;

namespace _5by5_Listas
{
    internal class Program
    {


        static void Menu()
        {
            Console.WriteLine("[1] - Print Phone Book ");
            Console.WriteLine("[2] - Insert new person in Phone Book ");
            Console.WriteLine("[3] - Remove person from Phone Book ");
        }


        static Adress SetAdress()
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

        static Person CreatePerson()
        {
            string name, email;
            Console.WriteLine("Write your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Write your email: ");
            email = Console.ReadLine();
            Person person = new Person(name, email, SetAdress());
            return person;
        }

       





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
    }

}
