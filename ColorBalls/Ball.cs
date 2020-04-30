namespace ColorBalls
{
    public class Ball
    {
        private Color color;
        private float size;
        private int NumberOfThrows;

        // Construtor (nao tem a instancia numberofthrows,pk a bola foi criada, ou seja , nao foi atirada ainda)
        public Ball(Color color,float size)
        {
            this.color = color;
            this.size = size;
            NumberOfThrows = 0;
        }



        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0 )
                NumberOfThrows++;
            
        }

        public int GetNumberOfThows()
        {
            return NumberOfThrows;

        }
    }
}