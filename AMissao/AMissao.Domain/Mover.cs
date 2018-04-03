using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMissao.Domain
{
    public abstract class Mover
    {
        private const int Intervalo = 10;
        public Point localizacao;
        public Point Localizacao { get { return localizacao; } }
        protected Game jogo;

        /// <summary>
        /// Instancias de mover recebem como parametro o bjeto game e uma posição atual
        /// </summary>
        public Mover(Game jogo, Point localizacao)
        {
            this.jogo = jogo;
            this.localizacao = localizacao;
        }

        /// <summary>
        /// O método checa a distancia de um Point em relação a posição atual do objeto.
        /// Se eles estiverem a uma distancia - definida por distance - de cada um, ele retorna true, se não retorna false 
        /// </summary>
        public bool Perto(Point ChecarLocalizacao, int distancia)
        {
            if (Math.Abs(localizacao.X - ChecarLocalizacao.X) < distancia && Math.Abs(localizacao.Y - ChecarLocalizacao.Y) < distancia)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Nesse método ele verifica se a distancia a ser percorrida ou a nova localização 
        /// vai ser maior que a borda, se não for, não faz nada.
        /// O método Move() tenta mover-se um passo em uma direção, Se ele conseguir, retorna o novo Point.
        /// Se chegar em um dos limites, retorna o Point original.
        /// </summary>
        public Point Move(Direction direcao, Rectangle bordas)
        {
            Point novalocalizacao = localizacao;
            switch (direcao)
            {
                case Direction.Cima:
                    if (novalocalizacao.Y - Intervalo >= bordas.Top)
                        novalocalizacao.Y -= Intervalo;
                    break;
                case Direction.Baixo:
                    if (novalocalizacao.Y + Intervalo <= bordas.Bottom)
                        novalocalizacao.Y += Intervalo;
                    break;
                case Direction.Esquerda:
                    if (novalocalizacao.X - Intervalo >= bordas.Left)
                        novalocalizacao.X -= Intervalo;
                    break;
                case Direction.Direita:
                    if (novalocalizacao.X + Intervalo <= bordas.Right)
                        novalocalizacao.X += Intervalo;
                    break;
            }
            return novalocalizacao;
        }

    }
}
