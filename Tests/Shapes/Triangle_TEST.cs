using Shapes;

namespace Tests
{
    public class Triangle_TEST
    {
        public bool Act()
        {
            Triangle triangleExample = new Triangle(12, 15, 9);

            double calculatedResult = triangleExample.GetAreaOfFigure();

            if (calculatedResult != 54)
                return false;

            bool isTriangleRectangular = triangleExample.CalculateAndReturnIfItIsRectangularFigure();

            if (isTriangleRectangular != true)
                return false;

            triangleExample.ChangeTrianglePoints(11, 11, 11);

            calculatedResult = triangleExample.GetAreaOfFigure();

            if (System.Math.Round(calculatedResult) != 52)
                return false;

            isTriangleRectangular = triangleExample.CalculateAndReturnIfItIsRectangularFigure();

            if (isTriangleRectangular != false)
                return false;

            return true;
        }
    }
}