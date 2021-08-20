using System;
using tabuleiro;
using pecas;

namespace Xadrez_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Digite posicao de Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Digite posicao de Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    
                    partida.executaMovimento(origem, destino);

                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

           }
       
    }
}
