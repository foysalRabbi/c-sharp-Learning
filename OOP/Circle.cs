using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Circle : Drawing
	{

		public double Redious { get; set; }
		public Circle()
		{
			Redious = 2;

		}
		public  double Area()
		{
			return Math.PI * Redious * Redious;
		}
	}
}
