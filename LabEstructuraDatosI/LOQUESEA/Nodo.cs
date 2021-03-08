namespace LOQUESEA
{
    class Nodo
    {
        private int Data;
        private Nodo Next;

        public int data
        {
            get { return Data; }
            set { Data = value; }
        }

        public Nodo next
        {
            get { return Next; }
            set { Next = value; }
        }
    }
}
