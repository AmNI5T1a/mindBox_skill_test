using System;
using Shapes;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list_OfShapes = new List<Shape>();
            //list_OfShapes.Add(new Circle(273));
            //list_OfShapes.Add(new Triangle(24, 1, 1, 1));

            foreach (Shape tempShape in list_OfShapes)
                System.Console.WriteLine(tempShape.GetAreaOfFigure());
        }
    }
}
