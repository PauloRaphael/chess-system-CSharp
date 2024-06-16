using tabuleiro;
using xadrez;
using XadrezConsole.xadrez;

namespace XadrezConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}