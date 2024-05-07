using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class PersonList
    {
        Person? head;
        Person? tail;

        public PersonList()
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
                int compare = string.Compare(contact.GetName(), head.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Person aux = head;
                    head = contact;
                    head.SetNext(aux);
                }
                else
                {
                    Person aux = head;
                    Person prev = head;
                    do
                    {
                        compare = string.Compare(contact.GetName(), aux.GetName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        //else
                        //{
                        //    prev.SetNext(contact);
                        //    contact.SetNext(aux);

                        //}
                    } while (aux != null && compare > 0);
                    prev.SetNext(contact);
                    contact.SetNext(aux);
                    if (aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }

        public void RemoveByName(string name)
        {
            if (!IsEmpty())
            {
                if (name == head.GetName())
                {
                    if (head == tail)
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
                        compare = name.Equals(aux.GetName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.SetNext(aux.getNext());
                            if (prev.getNext() == null)
                            {
                                tail = prev;
                            }
                        }

                    } while (compare == false && aux != null);

                    if (aux == null)
                    {
                        Console.WriteLine("Não existe o contato na lista");
                    }



                }
            }
        }

        public void PrintContactList()
        {
            Person aux = head;
            if (IsEmpty())
            {
                Console.WriteLine("No one Register");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    //Console.WriteLine(aux.PrintPhones());
                    aux = aux.getNext();

                } while (aux != null);

            }
        }

        public void AddPhoneByName(string name)
        {
            Person aux = head;
            
        }
        public string GetName(Person person)
        {
            return person.GetName();
        }
    }
}
