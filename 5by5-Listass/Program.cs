using _5by5_Listass;

namespace _5by5_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> list = new();
            list.Add(new("Guilherme", "123"));
            foreach (Contact item in list)
            {
                Console.WriteLine(item.ToString());
            }
            





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
}
