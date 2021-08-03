using System;

namespace DevTest
{
    class Circle : Shape
    {
        public Circle()
        {
        }

        public override double GetArea(double x, double y)
        {
            return Math.PI * Math.Pow(x, 2);
        }
    }
}
