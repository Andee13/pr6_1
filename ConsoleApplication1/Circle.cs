using System;

namespace ConsoleApplication1
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
        
        public override double getPerimetr()
        {
            return 2 * Math.PI * radius;
        }

        public override double getSquare()
        {
            return  Math.PI * radius * radius;
        }
    }
}