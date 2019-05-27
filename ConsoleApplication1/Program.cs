using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Figure [] figure = new Figure[3];
            figure[0] = new Triangle(2,3,4);
            figure[1] = new Circle(5);
            figure[2] = new Rectangle(2,10);
            int i = 1;
            foreach (var v in figure)
            {
                Console.WriteLine($"Perimetr for {i++} figure is {v.getPerimetr()} , square is {v.getSquare()}");
            }
        }
    }
}