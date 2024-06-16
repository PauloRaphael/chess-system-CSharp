using tabuleiro;

namespace XadrezConsole
{
    internal class Tela
    {
        public static void ImprimitTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) != null)
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
