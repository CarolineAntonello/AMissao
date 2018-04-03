using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Seifador : Enemy
    {
        /// <summary>
        /// o seifador começa com 10 pontos de vida
        /// </summary>
        public Seifador(Game jogo, Point localizacao) : base(jogo, localizacao, 6)
        {
            
        }

        /// <summary>
        /// Quando ele tem a oportunidade de se mover, há duas chances em tres de que vá em direção ao jogador e uma em tres de ficar parado.
        /// Depois que ele se move, ele verifica se ele está perto do jogador, se estiver ele ataca o jogador com até quatro pontos de dano. 
        /// </summary>
        public override void Mover(Random random)
        {
            if (PontoDeDano > 0)
            {
                var num = random.Next(1, 4);
                Direction direcaoMover;
                switch (num)
                {

                    case 1:
                        direcaoMover = AcharDirecaoJogador(jogo.LocalizacaoJogador);
                        this.localizacao = this.Move(direcaoMover, jogo.Bordas);
                        break;
                    case 2:
                        direcaoMover = AcharDirecaoJogador(jogo.LocalizacaoJogador);
                        this.localizacao = this.Move(direcaoMover, jogo.Bordas);
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