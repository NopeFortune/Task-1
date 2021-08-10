using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresTask
{
    public class Triangle : Figure
    {
        private double A;
        private double B;
        private double C;

        public Triangle()
        {

        }

        public Triangle(double a, double b, double c)
        {
            CanExist(a, b, c);
            A = a;
            B = b;
            C = c;
        }
        public override double Area()
        {
            double Perimeter = 0.5 * (A + B + C);
            double Area = Math.Sqrt(Perimeter * (Perimeter - A) * (Perimeter - B) * (Perimeter - C));

            return Math.Round(Area, 2);
        }

        #region CanExist
        /// <summary>
        /// Метод, проверяющий, возможность создать треугольник.
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public void CanExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new TriangleException("Такого треугольника не существует(сторона(ы) меньше 0)");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleException("Такого треугольника не существует(сторона больше суммы двух других)");
            }
        }

        #endregion

        #region RightTriangle
        /// <summary>
        /// Метод, проверяющий является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns></returns>

        public bool isRightTriangle(double a, double b, double c)
        {

            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
