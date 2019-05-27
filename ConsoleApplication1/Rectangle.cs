namespace ConsoleApplication1
{
    public class Rectangle : Figure
    {
        private double a;
        private double b;
        
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
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
        
        public override double getPerimetr()
        {
            return a + b;
        }

        public override double getSquare()
        {
            return a * b;
        }
    }
}