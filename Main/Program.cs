using System;
using Shapes;
using Shapes.Interfaces;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle shapeExample = new Circle(23);
            System.Console.WriteLine(shapeExample.GetAreaOfFigure());

            Triangle triangle = new Triangle(2, 2, 2);
            System.Console.WriteLine(triangle.GetAreaOfFigure());
            System.Console.WriteLine(triangle.CalculateAndReturnIfItIsRectangularFigure(23));
        }
    }
}
