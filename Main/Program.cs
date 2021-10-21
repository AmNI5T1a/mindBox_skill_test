using System;
using System.Collections.Generic;

using Tests;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle_TEST circleUnitTest = new Circle_TEST(3);
            System.Console.WriteLine(circleUnitTest.Act());
        }
    }
}
