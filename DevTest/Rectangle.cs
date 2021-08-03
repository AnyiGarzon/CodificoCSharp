namespace DevTest
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public override double GetArea(double x, double y)
        {
            return x * y;
        }
    }
}
