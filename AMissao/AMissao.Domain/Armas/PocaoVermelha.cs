using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class PocaoVermelha : Weapon
    {
        public bool Used { get; private set; }

        public override string Nome
        {
            get { return "Pocao Vermelha"; }
        }

        public PocaoVermelha(Game jogo, Point localizacao) : base(jogo, localizacao)
        {
            Used = false;
        }

        public override void Atacar(Direction direcao, Random random)
        {
            if (!Used)
            {
                this.jogo.AumentarVidaJogador(10, random);
                Used = true;
            }
        }
    }
}