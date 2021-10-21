using System;
using System.Collections.Generic;
using Shapes.Interfaces;

namespace Shapes
{
    public class Triangle : Shape, IRectangular
    {
        public List<double> points { get; private set; }
        public Triangle(double[] points)
        {
            this.points = new List<double>();

            for (int i = 0; i < 3; i++)
                this.points.Add(points[i]);
        }

        public Triangle(double firstPoint, double secondPoint, double thirdPoint)
        {
            this.points = new List<double>();

            this.points.Add(firstPoint);
            this.points.Add(secondPoint);
            this.points.Add(thirdPoint);
        }
        protected override void CalculateAreaOfFigure()
        {
            // Gerone's formule
            double semi_perimetr = ((points[0] + points[1] + points[2]) / 2);
            areaOfFigure = Math.Sqrt(semi_perimetr * (semi_perimetr - points[0]) * (semi_perimetr - points[1]) * (semi_perimetr - points[2]));
        }

        public override double GetAreaOfFigure()
        {
            CalculateAreaOfFigure();
            return areaOfFigure;
        }

        public bool CalculateAndReturnIfItIsRectangularFigure()
        {
            double potentialHypotenuse = points[0];

            foreach (double point in points)
            {
                if (point > potentialHypotenuse)
                    potentialHypotenuse = point;
            }

            points.Remove(potentialHypotenuse);

            double hypoSquare = Math.Round(potentialHypotenuse * potentialHypotenuse);
            double legsSquare = Math.Round(points[0] * points[0]) + (points[1] * points[1]);

            if (Math.Round(potentialHypotenuse * potentialHypotenuse) != Math.Round(points[0] * points[0]) + (points[1] * points[1]))
                return false;

            return true;
        }

        public void ChangeTrianglePoints(double firstPoint, double secondPoint, double thirdPoint)
        {
            points.Clear();
            points.Add(firstPoint);
            points.Add(secondPoint);
            points.Add(thirdPoint);
        }
    }
}