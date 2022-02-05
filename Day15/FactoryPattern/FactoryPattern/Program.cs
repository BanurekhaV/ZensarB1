using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape 
    { 
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle");
        }
    }

    public class ShapeFactory
    {
        public Shape getShape(string shapetype)
        {
            if (shapetype.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            else if (shapetype.Equals("Square"))
            {
                return new Square();
            }
            else if (shapetype.Equals("Circle"))
            {
                return new Circle();
            }
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            Shape s = sf.getShape("Rectangle");
            s.draw();
            s = sf.getShape("Square");
            s.draw();
            s = sf.getShape("Circle");
            s.draw();
            Console.Read();

        }
    }
}
