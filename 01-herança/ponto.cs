namespace Classes.Herança
{
    public class ponto
    {
        public int x, y;
        private int distancia;

        public ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //faz alguma coisa
        }
        private void CalcularDistancia2()
        {

        }
        public virtual void CalcularDistancia3()
        {
            
        }
    }
}