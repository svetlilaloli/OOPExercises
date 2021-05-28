namespace Shapes2
{
    using System;
    using System.Text;
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; private set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string Draw()
        {
            StringBuilder result = new();

            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;
            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        result.Append('*');
                    }
                    else
                    {
                        result.Append(' ');
                    }
                }
                result.Append('\n');
            }
            return result.ToString();
        }
    }
}
