using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    /// <summary>
    /// Класс для получения площадей фигур.
    /// </summary>
    public static class Area
    {
        /// <summary>
        /// Метод вычисляющий площадь фигуры без знания фигуры.
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        public static double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
