using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Phone
    {
        string phone;
        Phone next;

        public Phone(string phone)
        {
            this.phone = phone;
            this.next = null;
        }

        public override string? ToString()
        {
            return " " + phone;
        }

        public Phone getNext()
        {
            return this.next;
        }
        public void setNext(Phone next)
        {
            this.next = next;
        }
        public string getPhone()
        {
            return this.phone;
        }
    }
}
