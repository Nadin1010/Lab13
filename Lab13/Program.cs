using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab13.Properties;
using static System.Console;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва, 4-я Тверская-Ямская улица, дом16 ", "200м", "55м", "20м");
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("СПб, Кронверкский пр., дом49 ", "190м", "54м", "28м", "5м");
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    } 
}



