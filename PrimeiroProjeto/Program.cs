// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double A, B, C, bhaskara, delta, X1, X2;

            Console.WriteLine("Informe o valor de A");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor de B");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor de C");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(A > 0)
            {
                delta = Math.Pow(B, 2) - 4 * A * C;

                if(delta > 0)
                {

                    X1 = (double)(-B - Math.Sqrt(delta)) / (2 * A);
                    X2 = (double)(-B + Math.Sqrt(delta)) / (2 * A);

                    Console.WriteLine("X1 = " + X1);
                    Console.WriteLine("X2 = " + X2);
                } else
                {
                    Console.WriteLine("Delta negativo");
                }
            } else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
