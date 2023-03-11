namespace AreaLibrary
{
    public class Circle : Figure
    {
        private double _r;

        public double R {
            get
            {
                return _r;
            }
            private set
            {
                if(value<=0)
                    throw new ArgumentException("Некорректный радиус! Радиус круга строго больше 0.");
                else
                    _r = value;
            }
        }

        public Circle(double R)
        {
            this.R = R;
        }

        // Calculating Square
        public override double CalculatingSquare()
        {
            return (Math.PI * R * R);
        }
    }
}