namespace Shapes2
{
    using System.Text;
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Height { get; private set; }
        public double Width { get; private set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return (Height + Width) * 2;
        }
        public override string Draw()
        {
            StringBuilder result = DrawLine((int)Width, '*', '*');
            
            for (int i = 1; i < Height - 1; i++)
            {
                result.Append(DrawLine((int)Width, '*', ' '));
            }
            result.Append(DrawLine((int)Width, '*', '*'));
            return result.ToString();
        }
        private static StringBuilder DrawLine(int width, char end, char mid)
        {
            StringBuilder result = new();
            result.Append(end);
            for (int i = 1; i < width - 1; i++)
            {
                result.Append(mid);
            }
            result.Append($"{end}\n");
            return result;
        }
    }
}
