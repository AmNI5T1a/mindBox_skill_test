using System;
using Shapes.Interfaces;

namespace Shapes
{
    public class Triangle : Shape, IRectangular
    {
        protected override void CalculateAreaOfFigure()
        {
            throw new NotImplementedException();
        }

        public override double GetAreaOfFigure()
        {
            throw new NotImplementedException();
        }

        public void CalculateAndReturnIfItIsRectangularFigure()
        {
            throw new NotImplementedException();
        }
    }
}