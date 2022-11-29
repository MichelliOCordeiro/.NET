using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Calculadora.src
{
    internal interface IOperacoes
    {
        double AreaRetangulo(double b, double h);

        double AreaQuadrado(double b, double h);

        double AreaTriangulo(double b, double h);
    }
}