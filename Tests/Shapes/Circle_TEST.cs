using System;
using Shapes;
using System.Text;

namespace Tests
{
    public class Circle_TEST
    {
        public byte DigitsAfterDecimalPoint { get; private set; }

        public Circle_TEST(byte numberOfDigits)
        {
            this.DigitsAfterDecimalPoint = numberOfDigits;
        }
        public bool Act()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Circle circleShape = new Circle(435);

            string answer = Test(stringBuilder, circleShape);

            if (answer != "594467.859")
                return false;

            circleShape.ChangeCircleRadius(22);

            answer = Test(stringBuilder, circleShape);

            if (answer != "1520.530")
                return false;

            circleShape.ChangeCircleRadius(5);

            answer = Test(stringBuilder, circleShape);

            if (answer != "78.539")
                return false;


            return true;
        }

        private string Test(StringBuilder builder, Circle shape)
        {
            double calculatedResult = shape.GetAreaOfFigure();
            builder.Clear();

            string[] convertedResult = Convert.ToString(calculatedResult).Split('.');
            string allDigitsAfterDecimalPointFromResult = convertedResult[1];

            builder.Append(convertedResult[0]);
            builder.Append(".");
            for (byte c = 0; c < DigitsAfterDecimalPoint; c++)
            {
                builder.Append(allDigitsAfterDecimalPointFromResult[c]);
            }

            return builder.ToString();
        }

        public void ChangeNumberOfDigitsAfterDecimalPoint(byte newNumberOfDigits) => this.DigitsAfterDecimalPoint = newNumberOfDigits;
    }
}