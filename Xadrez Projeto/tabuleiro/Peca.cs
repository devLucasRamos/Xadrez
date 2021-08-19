namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Cor cor,Tabuleiro tab)
        {
            posicao = null;
            this.cor = cor;
            qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
