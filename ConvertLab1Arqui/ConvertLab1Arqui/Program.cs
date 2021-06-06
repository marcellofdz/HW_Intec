using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLab1Arqui
{
    class Program
    {
        static void Main(string[] args)
        {

            string salir = "no";

            while (salir.ToLower() == "no")
            {
                Console.WriteLine("Convertido de ASCII a Entero - Lab Arquitectura del computador");
                Console.WriteLine(" ================= SELECCIONE UNA OPCION ==================");
                Console.WriteLine("1. ASCII a Entero");
                Console.WriteLine("2. Entero a ASCII");
                Console.Write("Opción [1-2]: ");
                string opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("ASCII a Entero");
                            Console.Write("Ingrese un caracter: ");
                            char letra = Convert.ToChar(Console.ReadLine());
                            int num = (int)letra;
                            Console.WriteLine("El resultado de {0} en ASCII es {1}", letra,num);
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Entero a ASCII");
                            Console.Write("Ingrese un numero: ");
                            int num2 = int.Parse(Console.ReadLine());
                            char letra2 = (char)num2;
                            Console.WriteLine("El resultado de {1} en entero es {0}", letra2, num2);
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                }

                Console.Write("Desea salir? Si/no : ");
                salir = Console.ReadLine();
            }

            //Console.ReadLine();

        }
    }
}
