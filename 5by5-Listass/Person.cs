using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Person
    {
        string name;
        PhoneList phones;
        Adress adress;
        Person next;
        string email;

       
        public Person(string name,string email, Adress adress)
        {
            this.name = name;
            this.adress = adress;
            this.email = email;
            this.phones = new PhoneList();
           
            ;
        }
              
         
        public string GetName(){return this.name;}
        public void SetNext(Person c){ this.next = c;}
        public PhoneList GetPhone() { return this.phones;}
        public void AddPhone(Phone phone)
        {
            phones.AddPhone(phone);
        }
        public Person getNext()
        {
            return this.next;
        }
        public override string? ToString()
        {
            return "Name: " + this.name + "\nEmail: " + email + "\nPhones:\n " + phones.ToString();
        }
    }
}
