using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Properties
{
    sealed class MultiBuilding : Building
    {
       string numberofstoreys;

        public MultiBuilding(string adres, string length, string wigth, string heigth, string numberofstoreys)
            : base(adres, length, wigth, heigth)
        {
            this.numberofstoreys = numberofstoreys;
        }

        public string Print()
        {
            string result = base.Print();
            result += $" {numberofstoreys}";
            return result;
        }
    } 
}

