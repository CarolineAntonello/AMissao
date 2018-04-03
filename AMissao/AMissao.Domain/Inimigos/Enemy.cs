using System;
using System.Drawing;

namespace AMissao.Domain
{
    public abstract class Enemy : Mover
    {
        private const int JogadorPertoDistancia = 25;
        public int PontoDeDano { get; set; }
        /// <summary>
        /// O formulário pode usar essa propriedade apenas-leitura para ver se o inimigo deve ser visível na masmorra do jogo.
        /// </summary>
        public bool Dead
        {
            get
            {
                return PontoDeDano <= 0;
            }
        }

        public Enemy(Game jogo, Point localizacao, int pontosDeDano) : base(jogo, localizacao)
        {
            PontoDeDano = pontosDeDano;
        }

        public abstract void Mover(Random random);

        /// <summary>
        /// Quando o jogador ataca um inimigo, ele chama o método Hit() (dano) de enemy, que subtrai um númereo aleatório dos pontos de vida.
        /// </summary>
        public void Dano(int danoMaximo, Random random)
        {
            PontoDeDano -= random.Next(1, danoMaximo);
        }

        /// <summary>
        /// Este método usa o método estático Mover.Nearby() para descobrir se o inimigo esta perto do jogador.
        /// </summary>
        /// <returns></returns>
        protected bool JogadorPerto()
        {
            return (Perto(jogo.LocalizacaoJogador, JogadorPertoDistancia));
        }

        /// <summary>
        /// Esse método faz com que o inimigo persiga o jogador, olhando em que linha ele está(x ou y)
        /// Ele usará o campo location da classe base para descobrir onde o jogador esta em relação ao inimigo
        /// e retorna um enum Direction que informa em qual direção o inimigo precisa se mover para se aproximar do jogador.
        /// </summary>
        protected Direction AcharDirecaoJogador(Point localizacaoJogador)
        {
            Direction mover;
            if (localizacaoJogador.X > localizacao.X + 10)
                mover = Direction.Direita;
            else if (localizacaoJogador.X < localizacao.X - 10)
                mover = Direction.Esquerda;
            else if (localizacaoJogador.Y < localizacao.Y - 10)
                mover = Direction.Cima;
            else
                mover = Direction.Baixo;
            return mover;
        }

    }
}