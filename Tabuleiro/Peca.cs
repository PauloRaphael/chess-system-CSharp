namespace tabuleiro
{
    internal abstract class Peca
    {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos {  get; set; }
        public Tabuleiro Tab {  get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Tab = tab;
            Cor = cor;
            Posicao = null;
            QteMovimentos = 0;
        }

        public void incrementarQteMovimentos9()
        {
            QteMovimentos++;
        }
        
        public abstract bool[,] MovimentosPossiveis();
 
    } 
}