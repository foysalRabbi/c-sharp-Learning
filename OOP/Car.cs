using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Car:Vehicle
	{
        public double Speed { get; set; }
        public double Distance { get; set; }

        public static void CalculatedSpeed()
        {
            Console.WriteLine("Nothing to calculate");
        }
    }
}
