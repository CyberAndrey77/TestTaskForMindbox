using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius 
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be zero or less than zero");
                }
                _radius = value;
            }
        }

        public Circle() : this (1) { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Выичсляет площадь окружности.
        /// </summary>
        /// <returns>Площадь, округлёная до 4 знаков</returns>
        public double GetArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 4);
        }
    }
}
