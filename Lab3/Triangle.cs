using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs
{

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	class Triangle :Shape
    {

		private double oneSide;

		public Triangle(double p)
		{
			oneSide = Math.Abs(p);
			xPos = DataModel.getNewXPos();
			yPos = DataModel.getNewYPos();
		}

		public override double getArea()
		{
			return (oneSide * oneSide * Math.Sqrt(3)) / 4;
		}

		public override double getPerimeter()
		{
			return 3 * oneSide;
		}

		public override void printData()
		{
			Console.WriteLine();
			Console.WriteLine("My type: " + this.GetType());
			Console.WriteLine("Side of square = " + oneSide);
			Console.WriteLine("X position = " + xPos);
			Console.WriteLine("Y position = " + yPos);
		}

	}
}
