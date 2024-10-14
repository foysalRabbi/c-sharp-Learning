using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Box<T>
	{
		private T ? _item;

		public void Add(T item)
		{
			_item = item;
		}

		public T GetItem()
		{
			return _item;
		}

	}
}
