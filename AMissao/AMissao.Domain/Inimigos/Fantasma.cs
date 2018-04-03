using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Fantasma : Enemy
    {

        /// <summary>
        /// o fantasma começa com 8 pontos de vida
        /// </summary>
        public Fantasma(Game jogo, Point localizacao) : base(jogo, localizacao, 6)
        {

        }

        /// <summary>
        /// Quando ele vai se mover, existe uma chance de em tres de que ele vá na direção do jogador, e duas chances em tres de permanecer parado.
        /// Depois que o morcego se move, ele verifica se ele está perto do jogador, se estiver ele ataca o jogador com até tres pontos de dano. 
        /// </summary>
        public override void Mover(Random random)
        {
            {
                var num = random.Next(1, 4);
                switch (num)
                {
                    case 1:
                        Direction DirecaoMover = AcharDirecaoJogador(jogo.LocalizacaoJogador);
                        this.localizacao = this.Move(DirecaoMover, jogo.Bordas);
                        break;

                    default:
                        break;
                }
            }

            if (JogadorPerto() && !Dead)
                jogo.DanoDoJogador(3, random);
        }
    }
}