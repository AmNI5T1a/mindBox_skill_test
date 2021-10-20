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
            list_OfShapes.Add(new Circle());
            list_OfShapes.Add(new Triangle());

            foreach (Shape tempShape in list_OfShapes)
                System.Console.WriteLine(tempShape.GetAreaOfFigure());
        }
    }
}
