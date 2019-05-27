using System;

namespace ConsoleApplication1
{
    public class Triangle : Figure
    {
        
        private double a;
        private double b;
        private double c;
        
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }

        public double C
        {
            get => c;
            set => c = value;
        }

        public override double getPerimetr()
        {
            return a + b + c;
        }

        public override double getSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 1.0 / 2.0);
        }
    }
}