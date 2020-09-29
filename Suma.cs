using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraOOP
{
    class Suma : IOperacion
    {
        public double Ejecutar(double x, double y)
        {
            return x + y;
        }
    }
}
