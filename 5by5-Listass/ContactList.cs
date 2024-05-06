using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class ContactList
    {
        Person? head;
        Person? tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public void Add(Person contact)
        {
            if (IsEmpty())
            {
                this.head = this.tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Person aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Person aux = head;
                    Person prev = head;
                    do
                    {
                        compare = string.Compare(contact.getName(), aux.getName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        //else
                        //{
                        //    prev.setNext(contact);
                        //    contact.setNext(aux);
                            
                        //}
                    } while (aux != null && compare > 0);
                    prev.setNext(contact);
                    contact.setNext(aux);
                    if(aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }

        public void RemoveByName(string name)
        {
            if(!IsEmpty())
            {
                if (name == head.getName())
                {
                    if(head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                    head = head.getNext();
                    }
                }
                else
                {
                    Person aux = head;
                    Person prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.getName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.setNext(aux.getNext());
                            if (prev.getNext() == null)
                            {
                                tail = prev;
                            }
                        }

                    } while(compare == false && aux != null);

                    if(aux == null)
                    {
                        Console.WriteLine("Não existe o contato na lista");
                    }

          

                }
            }
        }
    }
}
