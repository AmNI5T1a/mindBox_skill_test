using System.Collections.Generic;
using Shapes;
using Tests;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>();
            listOfShapes.Add(new Circle(22));
            listOfShapes.Add(new Triangle(4, 4, 5));

            foreach (Shape tempShape in listOfShapes)
                System.Console.WriteLine(tempShape.GetAreaOfFigure());

            Triangle triangleExaple = new Triangle(12, 15, 9);
            System.Console.WriteLine(triangleExaple.GetAreaOfFigure());
            System.Console.WriteLine(triangleExaple.CalculateAndReturnIfItIsRectangularFigure());



            // * Tests
            Circle_TEST circleUnitTest = new Circle_TEST(3);
            System.Console.WriteLine(circleUnitTest.Act());

            Triangle_TEST triangleUnitTest = new Triangle_TEST();
            System.Console.WriteLine(triangleUnitTest.Act());
        }
    }
}
