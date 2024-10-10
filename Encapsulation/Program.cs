//#define DISTANCE
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

#if DISTANCE
			Point A = new Point();
			Point B = new Point();

			//Point C = new Point();
			Point C = new Point(B); //Конструктор копирования

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

			C.Print();

			Point D;    //Это НЕ объект, а ссылка на объект
			D = new Point(C);   //Объект можно создать только при помощи оператора 'new'
			D.Print();

			Console.WriteLine();

			double distance = A.Distance(B);
			Console.WriteLine($"Расстояние от точки A до точки B: {distance}");
			Console.WriteLine();

			double distance2 = Point.Distance(A, B);
			Console.WriteLine($"Расстояние между точками A и B: {distance2}");
			Console.WriteLine();
		} 
#endif

			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Point D = new Point(A - B);
			D.Print();

			for (Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}
		}
	}
}
