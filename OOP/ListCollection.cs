using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class ListCollection
	{
		public void Output()
		{
			var list = new List<int>(1000);

			list.Add(10);

			foreach (var item in list)
			{
				Console.WriteLine("Add in 10 -> " + item);
			}

			list.Insert(0, 4);

			foreach (var item in list)
			{
				Console.WriteLine("Insert in 0 -> " + item);
			}

			list.Remove(10);
			foreach (var item in list)
			{
				Console.WriteLine("Remove to 10 -> " + item);
			}

			list.RemoveAt(0);
			foreach (var item in list)
			{
				Console.WriteLine("After Remove At , result is -> " + item);
			}

			list.Add(20);
			list.Add(30);
			list.Add(40);
			foreach (var item in list)
			{
				Console.WriteLine("After adding , result is -> " + item);
			}
			var first = list[0];
			Console.WriteLine($"The first item is: {first}");

			var index = list.IndexOf(30);
			Console.WriteLine($"The index of item 30 is: {index}");

			var contains = list.Contains(30);
			Console.WriteLine($"Does the list contain 30? {contains}");
			var count = list.Count;
			Console.WriteLine($"The total number of items in the list is: {count}");
			foreach ( var item in list )
			{
				Console.WriteLine(item);
			}
		}
	}
}
