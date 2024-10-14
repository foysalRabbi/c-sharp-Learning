using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Point
	{
        public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		////two parameters that are integer
		public void Move(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// a class type as a parameter
		public void Move(Point newLocation)
		{
			if (newLocation == null)
				throw new ArgumentNullException("It's new location");

			Move(newLocation.X, newLocation.Y);

		}
    }
}
