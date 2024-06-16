using System.Runtime.InteropServices;
using Tabuleiro;

namespace XadrezConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Posição: " + new Posicao(3, 4));

            Console.ReadLine();
        }
    }
}