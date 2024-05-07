using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Listass
{
    internal class Adress
    {
        public string cep;
        string city;
        string uf;
        string street;
        string streetType;
        string district;
        int number;
        string complement;

        public Adress()
        {

        }
        public Adress(string cep, string city, string uf, string street, string StreetType, string district, int number, string complement)
        {
            this.cep = cep;
            this.city = city;
            this.uf = uf;
            this.street = street;
            this.streetType = StreetType;
            this.district = district;
            this.number = number;
            this.complement = complement;
        }
        public void SetCep(string cep) { this.cep = cep; }
        public void SetCity(string city) { this.city = city; }
        public void SetUF(string uf) { this.uf = uf; }
        public void SetStreet(string street) {  this.street = street; }
        public void SetStreetType(string st) { this.streetType = st; }
        public void SetDistrict(string district) { this.district = district; }
        public void SetNumber(int number) { this.number = number; }
        public void setComplement(string complement) { this.complement = complement; }


        public override string? ToString()
        {
            return "\nCep: " + cep + "\nCity: " + this.city + "\nUF: " + uf + "\nStreet: " + street + "\nStreet type: " + streetType + "\nDistrict: " + district + "\nNumber: " + number + "\nComplement: " + complement;
        }
    }


}
