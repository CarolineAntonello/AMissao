using System;
using System.Drawing;

namespace AMissao.Domain
{
    public abstract class Weapon : Mover
    {
        public abstract string Nome { get; }
        public bool FoiPega { get; set; }

        /// <summary>
        /// Inicia a arma colocando ela no jogo, setando uma posição e colocando um atributo indicando que não foi pega
        /// </summary>
        public Weapon(Game jogo, Point localizacao) : base(jogo, localizacao)
        {
            FoiPega = false;
        }

       public abstract void Atacar(Direction direcao, Random random);

        public void PegarArma()
        {
            this.FoiPega = true;
        }

        /// <summary>
        /// Nesse método é passado a direção do ataque, o angulo, o dano e o numero randomico para gerar o dano
        /// </summary>
        protected bool DanoInimigo(Direction direcao, int radius, int dano, Random random)
        {
            Point alvo = jogo.LocalizacaoJogador;

            for (var distancia = 0; distancia < radius; distancia++)
            {

                foreach (Enemy inimigo in jogo.Inimigos)
                {
                    if (Perto(inimigo.Localizacao, alvo, distancia))
                    {
                        inimigo.Dano(dano, random);
                        return true;
                    }
                }
                alvo = Mover(direcao, alvo, jogo.Bordas);
            }
            return false;
        }

        public bool Perto(Point a, Point b, int distancia)
        {
            return Math.Abs(a.X - b.X) < distancia && (Math.Abs(a.Y - b.Y) < distancia);
        }


        public Point Mover(Direction direcao, Point locationParaMover, Rectangle bordas)
        {
            localizacao = locationParaMover;
            return Move(direcao, bordas);
        }
    }
}
