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

            if (op == '+')
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
                    //throw new DivideByZeroException();
                }
            }
            
            

        }

        public static double Sumar(double X, double Y)
        {
            return X + Y;
        }
        public static double Restar(double X, double Y)
        {
            return X - Y;
        }
        public static double Dividir(double X, double Y)
        {
            return X / Y;
        }
        public static double Mulitplicar(double X, double Y)
        {
            return X * Y;
        }



    }

}
