using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Calculadora.src
{
    internal class Calc: IOperacoes
    {
        public double AreaRetangulo(double b, double h)
        {
            return b * h;
        }

        public double AreaQuadrado(double b, double h)
        {
            return b * h;
        }

        public double AreaTriangulo(double b, double h)
        {
            return (b * h) / 2;
        }
    }
}