using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangle : Figure
    {
        private double inaccuracy = 0.0000000000001;

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
                    throw new ArgumentException("Некорректные данные.Длина стороны треугольника должна быть строго больше 0.");
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
                    throw new ArgumentException("Некорректные данные.Длина стороны треугольника должна быть строго больше 0.");
                _b = value;
            }
        }

        private double _c;
        public double C
        {
            get
            {
                return _c;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Некорректные данные.Длина стороны треугольника должна быть строго больше 0.");
                _c = value;
            }
        }

        public Triangle(double A, double B, double C)
        {

            if (((A + B) <= C + inaccuracy) || ((A + C) <= B + inaccuracy) || ((B + C) <= A + inaccuracy))
            {
                throw new ArgumentException("Не существующий треугольник! Напоминание: Сумма любых двух сторон треугольника должна быть больше третьей стороны"); // В целом, этого условия достаточно и для проверки длины сторон на > 0 , т.к при любых значениях A,B,C < = 0 это условие не выполнится ( значение условия в if будет равно true ).
            }
            else
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
        }

        // Checking Rights of Triangle
        public bool IsRight()
        {
            if ((Math.Abs(A * A - (B * B + C * C)) < inaccuracy) || (Math.Abs(B * B - (A * A + C * C)) < inaccuracy) || (Math.Abs(C * C - (A * A + B * B)) < inaccuracy)) return true;
            else return false;
        }

        // Calculating Square
        public override double CalculatingSquare()
        {
            double P = (A + B + C);
            double p = P / 2;
            return (Math.Sqrt(p * (p - A) * (p - B) * (p - C)));
        }
    }
}
