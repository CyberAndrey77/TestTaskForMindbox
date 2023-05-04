using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : IFigure
    {
        private readonly List<double> _sides;

        public bool IsRightTriangle { get; private set; }

        public Triangle(double[] sides)
        {
            //Можно создавать самому сторону, если её не хватает или отбрасывать лишние,
            //но я думаю лучше уведомить что пришло не 3 стороны
            if (sides.Length != 3)
            {
                throw new ArgumentException("Triangle must have 3 sides");
            }

            _sides = new List<double>(3);

            if (IsSideOfTriangle(sides[0], sides[1], sides[2]))
            {
                _sides.Add(sides[0]);
            }
            if (IsSideOfTriangle(sides[1], sides[0], sides[2]))
            {
                _sides.Add(sides[1]);
            }
            if (IsSideOfTriangle(sides[2], sides[1], sides[0]))
            {
                _sides.Add(sides[2]);
            }
        }

        public Triangle(List<double> list) : this (list.ToArray()){}

        public Triangle(double side1, double side2, double side3) 
            : this (new double[3] { side1, side2, side3 }) { }

        /// <summary>
        /// Вычисление площади, округление до 4 знаков.
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double GetArea()
        {
            double sum = 0;
            for (int i = 0; i < _sides.Count; i++)
            {
                sum += _sides[i];
            }
            double p = sum / 2;
            return Math.Round(Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2])), 4);
        }

        private bool IsSideOfTriangle(double currentSide, double side1, double side2)
        {
            if (currentSide <= 0)
            {
                throw new ArgumentException("Side cannot be zero or less than zero");
            }
            if (currentSide >= side1 + side2)
            {
                throw new ArgumentException($"Triangle with side of {currentSide} cannot be");
            }
            if (IsSideHypotenuse(currentSide, side1, side2))
            {
                IsRightTriangle = true;
            }
            return true;
        }

        private bool IsSideHypotenuse(double currentSide, double side1, double side2)
        {
            return currentSide == Math.Sqrt(side1 * side1 + side2 * side2);
        }
    }
}
