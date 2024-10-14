using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOP
{
	internal class Person
	{
		// Properties
		// public double Salary { get; set; }
		
        public int Id { get; set; }
		public string Name { get; set; }
		// Class name = Method name is same.
		// default parameter
  //      public Person()
		//{

		//}
		//// parameterize constructor
		//public Person(int id, string name)
		//{
		//	this.Id = id;
		//	this.Name = name;
		//}
		public void DisplayPersonInfo(int id, string name)
		{
			Console.WriteLine($"ID: {id}");
			Console.WriteLine($"Name: {name}");
		}
	}

		
}
