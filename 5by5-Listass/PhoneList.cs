using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5by5_Listass
{
    internal class PhoneList
    {
        Phone head;
        Phone tail;

        public PhoneList()
        {
            this.head = null;
            this.tail = null;
        }
        bool IsEmpty()
        {
            return this.head == null && this.tail == null;
        }

        public void AddPhone(Phone phone)
        {
            if (IsEmpty())
            {
                this.head = this.tail = phone;
            }
            else
            {
                this.tail.setNext(phone);
                this.tail = phone;

            }
        }
        public void RemoveByNumber(string number) 
        {
            if (!IsEmpty()) 
            {
                if(number == this.head.GetPhoneNumber())
                {
                    if(this.head == this.tail)
                    {
                        this.head = this.tail = null;
                    }
                    else
                    {
                        head = head.getNext();
                    }

                }
                else
                {
                    Phone current = head;
                    Phone prev = head;
                    bool compare;
                    do
                    {
                        compare = number.Equals(current.GetPhoneNumber());
                        if (!compare)
                        {
                            prev = current;
                            current = current.getNext();
                        }
                        else
                        {
                            prev.setNext(current.getNext());
                            if (prev.getNext() == null)
                            {
                                tail = prev;
                            }
                        }

                    } while (compare == false && current != null);

                    if (current == null)
                    {
                        Console.WriteLine("Dont exist the phone in Phone List");
                    }
                }
            }
        }

        public override string? ToString()
        {
            Phone current = this.head;
            string phones = "";
            while(current != null)
            {
                phones += "\n" + current;
                current = current.getNext();

            }
            return phones;
        }
    }
}


