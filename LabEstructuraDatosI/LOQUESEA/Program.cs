using System;

namespace LOQUESEA
{
    class Program
    {
        static void Main(string[] args)
        {         
            try
            {
                List Lista = new List();               
                Lista.element();
                int a = Lista.Cont();
                for (int i = 0; i < a; i++)
                {
                    Lista.Insert();
                }
                Lista.Display();

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error. Debe escribir un numero. "+e.Message);    
            }           
        }
    }
}
    

