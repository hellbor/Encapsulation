using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	class Point
	{
		//double x;
		//double y;
		//public double X //Property
		//{
		//	get
		//	{
		//		return x;
		//	}
		//	set
		//	{
		//		if (value > 200) value = 200;
		//		x = value; //ключевое слово 'value' дает принимаемое значение
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 150) value = 150;
		//		y = value;
		//	}
		//}
		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x)
		//{
		//	if (x > 200) x = 200;
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	if (y > 150) y = 150;
		//	this.y = y;
		//}
		public double X {  get; set; }	//Автосвойства
		public double Y { get; set; }
		public Point(double x = 0, double y = 0)
		{
			this.X = x;
			this.Y = y;
            Console.WriteLine($"Constructor: {this.GetHashCode()}");
        }
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor: {GetHashCode()}");
		}
		~Point()
		{
            Console.WriteLine($"Destructor: {this.GetHashCode()}");
        }
		public static Point operator + (Point left, Point right)
		{
			Point res = new Point();
			res.X = left.X + right.X;
			res.Y = left.Y + right.Y;
			return res;
		}
		public static Point operator -(Point left, Point right)
		{
			return new Point
				(
				left.X - right.X,
				left.Y - right.Y
				);
		}
		public static Point operator ++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}
		public static bool operator ==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return !(left == right);
		}

		public void Print()
		{
			Console.WriteLine($"{GetHashCode()}:\tX={X}\tY={Y}");
			//Console.WriteLine($"X={GetX()}\tY={GetY()}");
		}

		/*public double Distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}*/
		public double Distance(Point other)
		{
			return Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
		}
		public static double Distance(Point A, Point B)
		{
			return Math.Sqrt(Math.Pow(A.X - B.Y, 2) + Math.Pow(A.Y - B.Y, 2));
		}
	}
}
