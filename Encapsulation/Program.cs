using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			Point B = new Point();
			//Console.WriteLine($"X={A.GetX()}\tY={A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = 22;
			A.Y = 33;
			A.Print();

			B.X = 11;
			B.Y = 15;
			B.Print();
            Console.WriteLine();

            double distance = A.Distance(B);
            Console.WriteLine($"Расстояние от точки A до точки B: {distance}");
			Console.WriteLine();

			double distance2 = Point.Distance(A, B);
			Console.WriteLine($"Расстояние между точками A и B: {distance2}");
			Console.WriteLine();
		}
	}
}
