using System;
using System.Collections.Generic;
using Shapes.Interfaces;

namespace Shapes
{
    public class Triangle : Shape, IRectangular
    {
        public List<double> points { get; private set; }
        public Triangle(int[] points)
        {
            this.points = new List<double>();

            for (int i = 0; i < 3; i++)
                this.points.Add(points[i]);
        }

        public Triangle(int firstPoint, int secondPoint, int thirdPoint)
        {
            this.points = new List<double>();

            this.points.Add(firstPoint);
            this.points.Add(secondPoint);
            this.points.Add(thirdPoint);
        }
        protected override void CalculateAreaOfFigure()
        {
            // Gerone's formule
            double semi_perimetr = (points[0] + points[1] + points[2]) / 2;
            areaOfFigure = Math.Sqrt(semi_perimetr * (semi_perimetr - points[0]) * (semi_perimetr - points[1]) * (semi_perimetr - points[2]));
        }

        public override double GetAreaOfFigure()
        {
            CalculateAreaOfFigure();
            return areaOfFigure;
        }

        public bool CalculateAndReturnIfItIsRectangularFigure(int inscribedCircleRadius)
        {
            double potentialHypotenuse = points[0];

            foreach (double point in points)
            {
                if (point > potentialHypotenuse)
                    potentialHypotenuse = point;
            }

            points.Remove(potentialHypotenuse);

            if ((potentialHypotenuse * potentialHypotenuse) != (points[0] * points[0]) + (points[1] * points[1]))
                return false;

            return true;
        }
    }
}