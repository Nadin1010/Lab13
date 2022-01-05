using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Properties
{
    class Building
    {
        string adres;
        string length;
        string wigth;
        string heigth;

        public string Adres
        {
            get { return adres;}
            set {adres = value;}
        }
        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Wigth
        {
            get { return wigth; }
            set { wigth = value; }
        }
        public string Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }
        public Building(string adres, string length, string wigth, string heigth)
        {
            this.Adres = adres;
            this.Length = length;
            this.Wigth = wigth;
            this.Heigth = heigth;
        }
        public string Print()
        {
            return $"{adres} {length} {wigth} {heigth}";
        }
    }
}