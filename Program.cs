using System;

namespace calculadoraOOP
{
    public enum OP {sum='+', rest='-', div='/', mult='*'}

    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;


            Console.WriteLine("Ingrese un numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor ingresado incorrecto");
            Console.WriteLine("Ingrese un operador");
            char x = char.Parse(Console.ReadLine());
            OP op = (OP)x;
            Console.WriteLine("Ingrese otro numero");
            num2 = double.Parse(Console.ReadLine());

            switch (op){
                case OP.sum:
                    Console.WriteLine(Sumar(num1, num2));
                    break;
                case OP.rest:
                    Console.WriteLine(Restar(num1, num2));
                    break;
                case OP.div:
                    Console.WriteLine(Dividir(num1, num2));
                    break;
                case OP.mult:
                    Console.WriteLine(Mulitplicar(num1, num2));
                    break;
                default:
                    Console.WriteLine("Operador incorecto");
                    break;
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
