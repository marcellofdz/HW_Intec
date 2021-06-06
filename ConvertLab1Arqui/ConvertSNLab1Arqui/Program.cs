using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSNLab1Arqui
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "no";

            Console.WriteLine("================ CONVERTIDOR DE BINARIO A DECIMAL  - Lab Arquitectura del computador ================");
            Console.WriteLine();
            while (salir.ToLower() == "no")
            {
                Console.WriteLine();
                Console.Write("Ingrese el numero binario: ");
                int Binario = int.Parse(Console.ReadLine());
                int vdecimal = 0;

                int base1 = 1;

                while (Binario > 0)
                {
                    int reminder = Binario % 10;
                    Binario = Binario / 10;
                    vdecimal += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.Write($"Valor en decimal es: {vdecimal} ");
                Console.ReadKey();
                Console.WriteLine();

                Console.Write("Desea salir? Si/no : ");
                salir = Console.ReadLine();
            }

        }
    }
}
