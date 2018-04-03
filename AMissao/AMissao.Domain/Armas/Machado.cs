using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Machado : Weapon
    {
        public override string Nome { get { return "Machado"; } }

        public Machado(Game jogo, Point localizacao) : base(jogo, localizacao)
        {

        }

        public override void Atacar(Direction direcao, Random random)
        {
            for (int i = 0; i < 4; i++)
            {
                DanoInimigo((Direction)i, 20, 6, random);
            }
        }
    }
}