using System;
using tabuleiro;
using pecas;

namespace Xadrez_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(5, 0));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(4, 3));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 4));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 5));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 3));


            Tela.imprimirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}
