using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Espada : Weapon
    {
        public override string Nome { get { return "Espada"; } }


        public Espada(Game jogo, Point localizacao) : base(jogo, localizacao)
        {

        }


        public override void Atacar(Direction direcao, Random random)
        {
            var direcaoDoAtaque = direcao;

            while (!DanoInimigo(direcaoDoAtaque, 10, 3, random) && (int)direcaoDoAtaque <= 3)
            {
                direcaoDoAtaque++;
            }

            while (!DanoInimigo(direcaoDoAtaque, 10, 3, random) && (int)direcaoDoAtaque >= 0)
            {
                direcaoDoAtaque--;
            }
        }
    }
}