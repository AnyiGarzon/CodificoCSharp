namespace DevTest
{
    public abstract class Shape
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public Shape()
        {
        }

        public Shape(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public virtual double GetArea(double x, double y)
        {
            return x * y;
        }
    }
}
