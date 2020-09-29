using System;

namespace calculadoraOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            char op;
            Suma sumar = new Suma();
            Resta restar = new Resta();
            Division dividir = new Division();
            Multiplicacion multiplicar = new Multiplicacion();

            IOperacion[] aOperadores = new IOperacion[4];
            aOperadores[0] = sumar;
            aOperadores[1] = restar;
            aOperadores[2] = dividir;
            aOperadores[3] = multiplicar;

            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese un numero");
                    num1 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor ingresado incorrecto");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese un operador");
                    op = char.Parse(Console.ReadLine());
                    
                    if (op != '+' && op != '-' && op != '*' && op != '/')
                    {
                        Console.WriteLine("El operador ingresado es desconocido");
                        continue;
                    }
                    else { break; }

                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor ingresado incorrecto");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese otro numero");
                    num2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor ingresado incorrecto");
                }
            }

            OPERADORES OP = (OPERADORES)op;

            switch (OP)
            {
                case OPERADORES.sum :
                    Console.WriteLine(aOperadores[0].Ejecutar(num1, num2));
                    break;
                case OPERADORES.rest:
                    Console.WriteLine(aOperadores[1].Ejecutar(num1, num2));
                    break;
                case OPERADORES.div:
                    Console.WriteLine(aOperadores[2].Ejecutar(num1, num2));
                    break;
                case OPERADORES.mult:
                    Console.WriteLine(aOperadores[3].Ejecutar(num1, num2));
                    break;

            }

            /*if (op == '+')
            {
                Console.WriteLine(Sumar(num1, num2));
            }
            else if (op == '-')
            {
                Console.WriteLine(Restar(num1, num2));
            }
            else if (op == '*')
            {
                Console.WriteLine(Mulitplicar(num1, num2));
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine(Dividir(num1, num2));
                }
                else
                {
                    Console.WriteLine("Imposible Dividir por cero");
                }
            }*/
        }
    }
    public enum OPERADORES {sum='+' , rest='-' , div='/' , mult='*' }


}
