using tabuleiro;
using xadrez;
using XadrezConsole.xadrez;

namespace XadrezConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimitTabuleiro(tab);

            Console.ReadLine();
        }
    }
}