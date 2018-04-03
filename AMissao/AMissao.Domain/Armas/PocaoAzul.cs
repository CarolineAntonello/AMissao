using System;
using System.Drawing;

namespace AMissao.Domain
{
    public class PocaoAzul : Weapon
    {
        public override string Nome
        {
            get { return "Pocao Azul"; }
        }
        
        public bool Used { get; private set; }

        public PocaoAzul(Game jogo, Point localizacao) : base(jogo, localizacao)
        {
            Used = false;
        }

        public override void Atacar(Direction direcao, Random random)
        {
            if (!Used)
            {
                this.jogo.AumentarVidaJogador(5, random);
                Used = true;
            }
        }
    }
}