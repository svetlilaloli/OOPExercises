namespace Shapes2
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Circle circle = new(5);
            Rectangle rectangle = new(5, 20);
            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
