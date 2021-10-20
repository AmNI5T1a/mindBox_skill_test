using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected double areaOfFigure;
        protected abstract void CalculateAreaOfFigure();
        public abstract double GetAreaOfFigure();
    }
}
