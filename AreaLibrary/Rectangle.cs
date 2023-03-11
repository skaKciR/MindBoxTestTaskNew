namespace AreaLibrary
{
    public class Rectangle : Figure
    {
        private double _a;
        public double A
        {
            get
            {
                return _a;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Некорректные данные.Длина стороны прямоугольника должна быть строго больше 0.");
                _a = value;
            }
        }

        private double _b;
        public double B
        {
            get
            {
                return _b;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Некорректные данные.Длина стороны прямоугольника должна быть строго больше 0.");
                _b = value;
            }
        }

        public Rectangle(double A, double B)
        {
                this.A = A;
                this.B = B;
        }

        // Calculating Square
        public override double CalculatingSquare()
        {
            return A * B;
        }
    }
}