using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Phone
    {
        string phoneNumber;
        Phone next;

        public Phone(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            this.next = null;
        }

        public override string? ToString(){return this.phoneNumber;}
        public Phone getNext(){return this.next;}
        public void setNext(Phone next){this.next = next;}
        public string GetPhoneNumber(){return this.phoneNumber;}
    }
}
