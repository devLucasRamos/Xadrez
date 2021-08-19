using System;
using tabuleiro;
using pecas;

namespace Xadrez_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            
                Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }

    }

}
