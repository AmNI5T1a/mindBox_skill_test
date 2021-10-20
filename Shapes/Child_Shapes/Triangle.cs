using System;
using System.Collections.Generic;
using Shapes.Interfaces;

namespace Shapes
{
    public class Triangle : Shape, IRectangular
    {
        private double inscribedCircleRadius;
        public List<double> points { get; private set; }
        public Triangle(int inscribedCircleRadius, int[] points)
        {
            this.inscribedCircleRadius = inscribedCircleRadius;
            for (int i = 0; i < 3; i++)
                this.points.Add(points[i]);
        }

        public Triangle(int inscribedCircleRadius, int firstPoint, int secondPoint, int thirdPoint)
        {
            this.inscribedCircleRadius = inscribedCircleRadius;
            this.points.Add(firstPoint);
            this.points.Add(secondPoint);
            this.points.Add(thirdPoint);
        }
        protected override void CalculateAreaOfFigure()
        {
            areaOfFigure = inscribedCircleRadius * (points[0] + points[1] + points[2]);
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
                if (point > potentialHypotenuse)
                    potentialHypotenuse = point;

            foreach (double point in points)
                if (point == potentialHypotenuse)
                    points.Remove(point);

            if ((potentialHypotenuse * potentialHypotenuse) != (points[0] * points[0]) + (points[1] * points[1]))
                return false;

            return true;
        }
    }
}