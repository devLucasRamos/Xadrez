namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Cor cor,Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
