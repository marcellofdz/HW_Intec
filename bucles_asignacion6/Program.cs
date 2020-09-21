using System;

namespace bucles_asignacion6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Desarrollar un programa que pregunte que clase de operación que programa correr, 
            el tipo de bucle y si desea continuar.*/

            #region ejercicio1
            /*
            //Que muestre los números descendentes del 1 al 100 de dos en dos


            Console.WriteLine("Mostrar los numeros descendentes del 1 a 100 de dos en dos");
            Int32 vNum;
            string vDesicion;

            do
            {
                Int32 x = 100;

                Console.Clear();
                Console.WriteLine("Favor seleccione  clase de operación que programa correr el tipo de bucle");
                Console.WriteLine(" 1) Ciclo While");
                Console.WriteLine(" 2) Ciclo For");
                Console.WriteLine(" 3) Ciclo Do-While");

                vNum = Convert.ToInt32(Console.ReadLine());

                if (vNum == 1) //aqui estoy usando el ciclo while
                    {

                Console.WriteLine("Ha seleccionado el ciclo While");
                    while (x > -1)
                        {                    
                            Console.WriteLine("Valor: {0}", x);
                            x -= 2;
                        }
                        Console.WriteLine("------------------ Fin del programa ------------------");
                    }

            else if (vNum == 2) //Aqui estoy usando el ciclo for
            {
                Console.WriteLine("Ha seleccionado el ciclo For");

                for (int i = 100 ; i > -1 ; i-=2)
                {
                    Console.WriteLine("Valor: {0}", i);
                }

                Console.WriteLine("------------------ Fin del programa ------------------");

            }

            else if (vNum == 3) //Aqui estoy usando el cicle Do-While
            {
                Console.WriteLine("Ha seleccionado el ciclo Do-While");

                do
                {
                    Console.WriteLine("Valor: {0}", x);
                    x -= 2;
                } 
                
                while (x >-1);

                
            }

                Console.WriteLine("¿Desea repetir el proceso?");
                Console.WriteLine("y/n");
                vDesicion = Console.ReadLine();
                if (vDesicion == "n")
                {
                    Console.WriteLine("------------------ Fin del programa ------------------");
                    break;
                }

            } 
            
            while (true);
            

            Console.ReadKey();
            Console.Clear();

            */
            #endregion



            #region ejercicio2

            //Que pida un número y muestre la tabla del 1 al 12 de dicho número;

            Int32 vNum1, vR, vCon = 0;

            Console.WriteLine("Mostrar la tabla hasta el 12 de cualquier numero.");
            Console.Write("Dame un numero: ");
            vNum1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {

               // Console.WriteLine("La tabla del {0}", vNum1);
                vR = vNum1 * i;
                Console.WriteLine(vNum1 + " * " + i+ " = " + vR);
            }

            Console.WriteLine("------------------ Fin del programa ------------------");
            Console.ReadKey();
            Console.Clear();

            #endregion






        }

    }
}