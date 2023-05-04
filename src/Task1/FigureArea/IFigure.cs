using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    //Можно использовать и абстрактный класс, но мне интерфесы больше нравятся
    public interface IFigure
    {
        double GetArea();
    }
}
