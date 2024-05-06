using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Adress
    {
        string cep;
        string city;
        string uf;
        string street;
        string StreetType;
        string district;
        int number;
        string complement;

        public Adress(string cep, string city, string uf, string street, string StreetType, string district, int number, string complement)
        {
            this.cep = cep;
            this.city = city;
            this.uf = uf;
            this.street = street;
            this.StreetType = StreetType;
            this.district = district;
            this.number = number;
            this.complement = complement;
        }

        public override string? ToString()
        {
            return "\nCep: " + cep + "\nCity: " + this.city + "\nUF: " + uf + "\nStreet: " + street + "\nStreet type: " + StreetType + "\nDistrict: " + district + "\nNumber: " + number + "\nComplement: " + complement;
        }
    }


}
