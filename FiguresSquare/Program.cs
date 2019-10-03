using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one side");
            string side = Console.ReadLine();
            int S = Convert.ToInt32(side);

            Console.WriteLine("Please enter other side");
            string sideb = Console.ReadLine();
            int B = Convert.ToInt32(sideb);

            Triangle vartriangle = new Triangle(S, B);
            vartriangle.GetSquare();
            Console.ReadLine();

            Rectangle varrectangle = new Rectangle(S, B);
            varrectangle.GetSquare();
            Console.ReadLine();

            Circle varcircle = new Circle(S);
            varcircle.GetSquare();
            Console.ReadLine();
        }

        class Square
        {
            public int Side { get; set; }

            public Square(int side)
            {
                Side = side;
            }

        }

        class Triangle : Square
        {
            public int Height { get; set; }
            public int TriangleSquare { get; set; }

            public Triangle(int side, int height) 
                :base (side)
            {
                Height = height;
                TriangleSquare = side * height / 2;
            }

            public void GetSquare()
            {
                Console.WriteLine("Площа трикутника =" + TriangleSquare);
            }
        }

       class Rectangle : Square
        {
            public int SideB { get; set; }
            public int RectangleSquare { get; set; }

            public Rectangle(int side, int sideb) : base (side)
            {
                SideB = sideb;
                RectangleSquare = side * sideb;
            }
            public void GetSquare()
            {
                Console.WriteLine("Площа прямокутника =" + RectangleSquare);
            }
        }

        class Circle : Square
        {
            public static double P=3.14;
            public double CircleSquare { get; set; }

            public Circle(int side) : base (side)
            {
                CircleSquare = P * side * side;
            }

            public void GetSquare()
            {
                Console.WriteLine("Площа кола =" + CircleSquare);
            }
        }
    }
}
