using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresTask
{
    public class Circle : Figure
    {
        private double Radius;

        public Circle(double radius)
        {
            CanExist(radius);
            Radius = radius;
        }
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        #region CanExist
        /// <summary>
        /// Метод, проверяющий, может ли существовать круг.
        /// </summary>
        /// <param name="radius">Радус круга.</param>
        protected void CanExist(double radius)
        {
            if (radius <= 0)
            {
                throw new CircleException("Радиус не может быть меньше, или равен нулю.");
            }
        }
        #endregion
    }
}
