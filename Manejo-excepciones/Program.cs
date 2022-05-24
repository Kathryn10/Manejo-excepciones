using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int Resultado;

            try
            {
                Console.Write("Ingrese un núnero entero: ");
                num = int.Parse(Console.ReadLine());

                Resultado = num * num;

                Console.WriteLine("\nEl cuadrado de " + num + " es: " + Resultado);
                Console.ReadLine();
            }
            catch(OverflowException)
            {
                Console.WriteLine("\nNúmero demasiado grande");
                Console.ReadLine();
            }
            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
                Console.ReadLine();
            }
        }
    }
}
