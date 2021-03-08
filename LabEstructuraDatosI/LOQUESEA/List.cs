using System;

namespace LOQUESEA
{
    class List
    {
        private int Const;
        private Nodo First = new Nodo();
        private Nodo Last = new Nodo();
        private int Element;
        public List()
        {
            First = null;
            Last = null;
        }
        public int Cont()
        {
            int a;
            Console.WriteLine("Cuantos numeros quiere agregar al nodo:");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
            return a;
        }
        
        public void Insert()
        {
            Nodo New = new Nodo();
            Console.WriteLine("Ingrese un dato para el nodo");
            New.data = int.Parse(Console.ReadLine());
            if (First == null)
            {
                First = New;
                First.next = First;
                Last = First;
            }
            else
            {
                Last.next = New;
                New.next = First;
                Last = New;
            }
        }
        public void element() 
        {
            Console.WriteLine("Ingrese el elemento a contabilizar");
            Element = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void Display()
        {
            Nodo Actual = new Nodo();
            Actual = First;
            if(Actual != null)
            {
                do
                {
                    if (Actual.data == Element)
                    {
                        Const++;
                    }
                    Actual = Actual.next;
                } while (Actual != First);
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
            Console.WriteLine(@"El elemento '{0}' se encontro {1} veces",Element,Const);
        }
    }
}
