namespace FigureLib
{
    public interface IFigure
    {
        double GetArea();
    }

    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

    }

    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            if (!IsTriangleExists(a, b, c))
                throw new ArgumentException("Triangle with the given sides does not exist.");

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightAngled()
        {
            double maxSide = Math.Max(Math.Max(_a, _b), _c);
            double sumSquares = Math.Pow(_a, 2) + Math.Pow(_b, 2) + Math.Pow(_c, 2);
            double otherTwoSquares = 2 * Math.Pow(maxSide, 2);
            return Math.Abs(sumSquares - otherTwoSquares) < double.Epsilon;
        }

        private static bool IsTriangleExists(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}