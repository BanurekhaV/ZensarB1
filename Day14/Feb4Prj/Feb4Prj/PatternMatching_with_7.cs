using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class PatternMatching_with_7
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            DisplayArea1(circle);
            Rectangle rectangle = new Rectangle(5, 7);
            DisplayArea1(rectangle);
            Triangle triangle = new Triangle(10, 5);
            DisplayArea1(triangle);
            //checking the when condition
            DisplayArea2(rectangle);
            Rectangle rect = new Rectangle(5, 5);
            DisplayArea2(rect);
            
            Console.Read();
        }
        public static void DisplayArea(Shape shape) //normal way of decision making
        {
            if (shape is Circle c)
            {
                //Circle c = (Circle)shape;
                Console.WriteLine("Area of Circle is " + " " + c.r * c.r * Shape.PI);
            }
            else if (shape is Rectangle r)
            {
                //Rectangle r = (Rectangle)shape;
                Console.WriteLine("Area of Rectangle :" + " " + r.l * r.b);
            }
            else if (shape is Triangle t)
            {
                //riangle t = (Triangle)shape;
                Console.WriteLine("Area of Triangle :" + " " + t.b * t.h);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }

        //pattern matching function with switch case
        public static void DisplayArea1(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine("Area of Circle is " + " " + c.r * c.r * Shape.PI);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle :" + " " + r.l * r.b);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Traingle :" + " " + t.b * t.h);
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }

        //pattern matching with when in switch case
        public static void DisplayArea2(Shape shape)
        {
            switch (shape)
            {
                case Rectangle r when r.l == r.b:
                    Console.WriteLine("Area of Square : " + " " + r.l * r.b);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle :" + " " + r.l * r.b);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle is " + " " + c.r * c.r * Shape.PI);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Traingle :" + " " + t.b * t.h);
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }
    }
}
