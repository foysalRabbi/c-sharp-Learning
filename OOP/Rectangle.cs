using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Rectangle :Drawing
	{
        public double Length { get; set; }
		public double Width { get; set; }

		public Rectangle()
		{
			Length = 8;
			Width = 5;
		}

		public override double Area()
		{
			return Length*Width;
		}
    }
}
