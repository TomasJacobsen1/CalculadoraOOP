using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraOOP
{
    class GetOp
    {
        public static IOperacion GetOperacion()
        {
            char op;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese un operador");
                    op = char.Parse(Console.ReadLine());

                    OPERADORES OP = (OPERADORES)op;

                    switch (OP)
                    {
                        case OPERADORES.sum:
                            return new Suma();
                        case OPERADORES.rest:
                            return new Resta();
                        case OPERADORES.div:
                            return new Division();
                        case OPERADORES.mult:
                            return new Multiplicacion();
                        default:
                            Console.WriteLine("El operador ingresado es incorrecto");
                            break;


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor ingresado incorrecto");
                }
            }
        }
    }
    public enum OPERADORES { sum = '+', rest = '-', div = '/', mult = '*' }
}
