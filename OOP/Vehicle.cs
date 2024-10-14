using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Vehicle
	{
        public string Name { get; set; }
		public string Brand { get; set; }

		public  void Move()
		{
			Console.WriteLine($"{Brand} {Name} is in motion.");
		}
		public  void Stop()
		{
			Console.WriteLine("Vehicle in stationary sate.");
		}
    }
}
