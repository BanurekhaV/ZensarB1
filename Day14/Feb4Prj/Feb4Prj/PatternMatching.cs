using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Shape
    {
        public const float PI= 3.14f;
    }
    class Circle :Shape
    {
        public int r;
        public Circle(int r)
        {
            this.r = r;
        }
    }
    class Rectangle :Shape
    {
       public int l, b;
        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
    }
    class Triangle :Shape
    {
       public int b, h;
        public Triangle(int b, int h)
        {
            this.b = b;
            this.h = h;
        }
    }
    class PatternMatching
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            DisplayArea(circle);
            Rectangle rectangle = new Rectangle(5, 7);
            DisplayArea(rectangle);
            Triangle triangle = new Triangle(10, 5);
            DisplayArea(triangle);
            Console.Read();
        }
        //pattern matching before C# 7.0
        public static void DisplayArea(Shape shape)
        {
            if(shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Area of Circle is " + " " + c.r*c.r*Shape.PI);
            }
            else if(shape is Rectangle)
            {
                Rectangle r = (Rectangle)shape;
                Console.WriteLine("Area of Rectangle :"+ " " + r.l*r.b);
            }
            else if(shape is Triangle)
            {
                Triangle t = (Triangle)shape;
                Console.WriteLine("Area of Triangle :"+ " " + t.b*t.h);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }
    }
}
