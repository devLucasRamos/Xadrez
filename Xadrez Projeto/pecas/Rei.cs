using System;
using tabuleiro;

namespace pecas
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { 
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
