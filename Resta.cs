using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraOOP
{
    class Resta : IOperacion
    {
        public double Ejecutar(double x, double y)
        {
            return x - y;
        }
    }
}
