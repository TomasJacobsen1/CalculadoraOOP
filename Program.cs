using System;

namespace calculadoraOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            
           
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
            IOperacion ejecutar = GetOp.GetOperacion(); 

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
            
            Console.WriteLine(ejecutar.Ejecutar(num1 , num2));
        }


    }
}
