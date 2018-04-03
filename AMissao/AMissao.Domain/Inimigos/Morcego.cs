using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Morcego : Enemy
    {
        /// <summary>
        /// o morcego começa com 6 pontos de vida, logo ele passa 6 ao construtor da classe base
        /// </summary>
        public Morcego(Game jogo, Point localizacao) : base(jogo, localizacao, 6)
        {
        }

        /// <summary>
        /// o morcego continuará se movendo em direção ao jogador e atacando, desde que tenha um ou mais pontos de vida.
        /// Quando o morcego se move, há 50% de chance de movimento para o jogador e 50% de chance de movimento em uma direção aleatória.
        /// Depois que o morcego se move, ele verifica se ele está perto do jogador, se estiver ele ataca o jogador com até dois pontos de dano. 
        /// </summary>
        public override void Mover(Random random)
        {

            Direction direcaoMover;

            if (this.PontoDeDano >= 1)
            {
                direcaoMover = AcharDirecaoJogador(jogo.LocalizacaoJogador);
                this.localizacao = this.Move(direcaoMover, jogo.Bordas);

            }
            else
            {
                direcaoMover = (Direction)random.Next(0, 5);
                this.localizacao = this.Move(direcaoMover, jogo.Bordas);
            }

            if (JogadorPerto() && !Dead)
            {
                jogo.DanoDoJogador(2, random);
            }
        }
    }
}