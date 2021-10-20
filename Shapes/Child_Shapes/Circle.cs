using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public double radius { get; private set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        protected override void CalculateAreaOfFigure()
        {
            areaOfFigure = (radius * radius) * 3.1415926;
        }

        public override double GetAreaOfFigure()
        {
            CalculateAreaOfFigure();
            return areaOfFigure;
        }
    }
}