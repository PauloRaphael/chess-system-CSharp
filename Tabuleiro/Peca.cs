namespace tabuleiro
{
    internal class Peca
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
    }
}
