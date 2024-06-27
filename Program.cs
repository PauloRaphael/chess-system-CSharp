using tabuleiro;
using XadrezConsole.xadrez;

namespace XadrezConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimitTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimitTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
