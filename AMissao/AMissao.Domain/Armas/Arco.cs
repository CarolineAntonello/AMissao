using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class Arco : Weapon
    {
        public override string Nome { get { return "Arco"; } }

        public Arco(Game jogo, Point localizacao) : base(jogo, localizacao)
        {

        }

        public override void Atacar(Direction direcao, Random random)
        {
            DanoInimigo(direcao, 30, 1, random);
        }
    }
}