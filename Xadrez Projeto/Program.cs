using System;
using tabuleiro;

namespace Xadrez_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}
