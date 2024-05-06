using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Person : ListOfPhone
    {
        string completeName;
        ListOfPhone phone;
        Adress adress;
        Person next;
        string email;

        public Person(string name,string email, Adress adress,ListOfPhone listPhones)
        {
            this.completeName = name;
            this.adress = adress;
            this.email = email;
            phone = listPhones;
        }


        public void PrintPerson()
        {
            Console.WriteLine("Name: " + this.completeName + "\nEmail: " + email + "\nAdress" + this.adress.ToString() + "\nPhones: " + phone.PrintPhones());
        }
        

        public string getName()
        {
            return this.completeName;
        }
        public void setNext(Person c)
        {
            this.next = c;
        }
        public Person getNext()
        {
            return this.next;
        }
    }
}
