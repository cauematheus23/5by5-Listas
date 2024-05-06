using _5by5_Listass;

namespace _5by5_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person caue = new("Cauê", "cauematheus_23@hotmail.com", new("14807040", "Araraquara", "SP", "Doutor adhemar", "Avenida", "Melhado", 54, "casa 55"), new());
            ContactList contactList = new ContactList();
            
            caue.AddPhone(new("1630141041"));
            caue.AddPhone(new("16997552763"));
            contactList.Add(caue);
            contactList.Add(new("Ana" , "Ana@hotmail.com", new("14807040" , "Sergipe" , "SP", "Doutor adhemar" , "Avenida", "Melhado", 54 , "casa 55"),new()));

            
            contactList.PrintContactList();
            






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
