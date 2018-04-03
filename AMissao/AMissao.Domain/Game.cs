using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AMissao.Domain
{
    public class Game
    {
        public List<Enemy> Inimigos { get; set; }
        public Weapon LocazicaoArmas { get; set; }
        private Player jogador;
        public Point LocalizacaoJogador { get { return jogador.Localizacao; } }
        public int PontoDanoJogador { get { return jogador.PontoDanoJogador; } set { } }
        public List<string> ArmasJogador { get { return jogador.Armas; } }
        private int nivel = 0;
        public int Nivel { get { return nivel; } }
        
        /// <summary>
        /// O objeto rectangle possui um campo Top(em cima), Botton(embaixo), Left(esquerda) e Right(direita) 
        /// e funciona perfeitamente para a área geral do jogo
        /// </summary>
        public Rectangle Bordas { get; set; }

        /// <summary>
        /// game começa criando uma caixa que envolve a masmorra e depois cria um novo objeto Player nela.
        /// </summary>
        public Game(Rectangle bordas)
        {
            this.Bordas = bordas;
            jogador = new Player(this, new Point(Bordas.Left + 10, Bordas.Top + 70));
        }

        /// <summary>
        /// O movimento é simples: mova o jogador na direção que o formulário informa e mova cada inimigo em uma direção aleatória
        /// </summary>
        public void Move(Direction direcao,Random random)
        {
            jogador.Mover(direcao);

            foreach (Enemy inimigo in Inimigos)
            {
                inimigo.Mover(random);
            }

        }

        #region Exemplos de encapsulamento
        /// <summary>
        /// Estes são exemplos de encapsulamento.Game não sabe como Player lida com essas ações,
        /// ele apenas passa a informação necessária e deixa player fazer o resto
        /// </summary>
        public void Equipar(string NomeDaArma)
        {
            jogador.Equipar(NomeDaArma);
        }

        public bool ChecarInventario(string NomeDaArma)
        {
            return jogador.Armas.Contains(NomeDaArma);
        }
        
        public void DanoDoJogador(int Danomaximo, Random random)
        {
            jogador.Dano(Danomaximo, random);
        }
        
        public void AumentarVidaJogador(int vida, Random random)
        {
            jogador.AumentarVidaJogador(vida, random);
        }
        #endregion

        /// <summary>
        /// É quase igual a Move(), o jogador ataca e os inimigos todos tem sua vez de jogar
        /// </summary>
        public void Atacar(Direction direcao, Random random)
        {
            jogador.Atacar(direcao, random);

            foreach (Enemy inimigos in Inimigos)
            {
                inimigos.Mover(random);
            }
        }

        public void Dano(int danoMaximo, Random random)
        {
            PontoDanoJogador -= random.Next(1, danoMaximo); 
        }


        /// <summary>
        /// Será util para o método NewLeve(), usado para determinar onde colocar os inimigos e as armas
        /// Isso é um truque matemático para conseguir um local aleatório dentro do retangulo que representa a área da masmorra
        /// </summary>
        private Point GetRandomLocation(Random random)
        {
            return new Point(Bordas.Left + random.Next(Bordas.Right / 10 - Bordas.Left / 10) * 10, Bordas.Top +
                random.Next(Bordas.Bottom / 10 - Bordas.Top / 10) * 10);
        }


        /// <summary>
        /// Só acresenta o comando case para o nivel 1. É sua função adicionar camadas case para outros níveis
        /// </summary>
        public void NovoNivel(Random random)
        {
            nivel++;
            CriarNivel(nivel, random);
        }

        private void CriarNivel(int nivel, Random random)
        {
            switch (nivel)
            {
                case 1:
                    Inimigos = new List<Enemy>()
                    {
                          new Morcego(this, GetRandomLocation(random))

                    };

                    LocazicaoArmas = new Espada(this, GetRandomLocation(random));
                    break;


                case 2:
                    Inimigos = new List<Enemy>()
                    {
                        new Fantasma(this, GetRandomLocation(random))
                    };

                    LocazicaoArmas = new PocaoAzul(this, GetRandomLocation(random));
                    break;



                case 3:
                    Inimigos = new List<Enemy>()
                    {
                        new Seifador(this, GetRandomLocation(random))
                    };

                    LocazicaoArmas = new Arco(this, GetRandomLocation(random));
                    break;



                case 4:
                    Inimigos = new List<Enemy>()
                    {
                        new Morcego(this, GetRandomLocation(random)),
                        new Fantasma(this, GetRandomLocation(random)),
                    };

                    if (!ChecarInventario("Arco"))
                    {
                        LocazicaoArmas = new Arco(this, GetRandomLocation(random));
                    }
                    else
                    {
                        LocazicaoArmas = new PocaoAzul(this, GetRandomLocation(random));
                    }
                    break;


                case 5:
                    Inimigos = new List<Enemy>()
                    {
                        new Morcego(this, GetRandomLocation(random)),
                        new Seifador(this, GetRandomLocation(random))
                    };
                    LocazicaoArmas = new PocaoVermelha(this, GetRandomLocation(random));
                    break;


                case 6:
                    Inimigos = new List<Enemy>()
                    {
                        new Fantasma(this, GetRandomLocation(random)),
                        new Seifador(this, GetRandomLocation(random))
                    };
                    LocazicaoArmas = new Machado(this, GetRandomLocation(random));
                    break;


                case 7:
                    Inimigos = new List<Enemy>()
                    {
                        new Morcego(this, GetRandomLocation(random)),
                        new Fantasma(this, GetRandomLocation(random)),
                        new Seifador(this,GetRandomLocation(random))
                    };
                    if (!ChecarInventario("Machado"))
                    {
                        LocazicaoArmas = new Machado(this, GetRandomLocation(random));
                    }
                    else
                    {
                        LocazicaoArmas = new PocaoVermelha(this, GetRandomLocation(random));
                    }

                    break;
            }
        }

    }

    
}
