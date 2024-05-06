using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5by5_Listass
{
    internal class ListOfPhone
    {
        Phone head;
        Phone tail;

        public ListOfPhone()
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
                if (number == this.head.getPhone())
                {
                    if (this.head == this.tail)
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
                        compare = number.Equals(current.getPhone());
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
        public string PrintPhones()

        {
            Phone aux = head;
            if (IsEmpty())
            {
                return "No one number registered";
            }
            else
            {
                string result = "";
                do
                {
                    result += aux.ToString() + "\n";
                    aux = aux.getNext();

                } while (aux != null);
                return result;

            }
        }
    }
}
