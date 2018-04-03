using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMissao.Domain
{
    public class Player : Mover
    {
        private Weapon armaEquipada;
        public int PontoDanoJogador { get; set; }
        private List<Weapon> inventario = new List<Weapon>();

        /// <summary>
        /// Contrói uma lista de armas contendo somente o nome delas
        /// </summary>
        public List<string> Armas
        {
            get
            {
                List<string> nomes = new List<string>();
                foreach (Weapon arma in inventario)
                {
                    nomes.Add(arma.Nome);
                }
                return nomes;
            }
        }

        /// <summary>
        /// Player herda de Mover então, este método passa Game e o local para aquela classe base. 
        /// O construtor de player atribui 10 para o valor de danos do jogador e chama o construtor da classe base.
        /// </summary>
        public Player(Game jogo, Point localizacao) : base(jogo, localizacao)
        {
            PontoDanoJogador = 10;
        }

        /// <summary>
        /// Quando um inimigo ataca um jogador, ele causa uma quantidade de dano aleatório.
        /// </summary>
        internal void Dano(int danoMaximo, Random random)
        {
            PontoDanoJogador -= random.Next(1, danoMaximo);
        }

        /// <summary>
        /// Método que será utilizado por alguma pocao para aumentar a vida.
        /// Quando a poção aumenta os pontos do jogador, a quantidade aumentada também é aleatória.
        /// </summary>
        public void AumentarVidaJogador(int vida, Random random)
        {
            PontoDanoJogador += random.Next(1, vida);
        }

        /// <summary>
        /// Equipa a arma verificando se ela existe na lista de armas, faz isso pelo nome
        /// </summary>
        internal void Equipar(string NomeDaArma)
        {
            foreach (var arma in inventario)
            {
                if (arma.Nome == NomeDaArma)
                {
                    armaEquipada = arma;
                }
            }
        }

        /// <summary>
        /// Se ele usar arma ele ataca, se for poção ele ainda ataca mas ela é removida so inventário
        /// </summary>
        internal void Atacar(Direction direcao, Random random)
        {
            armaEquipada.Atacar(direcao, random);

            if (armaEquipada is IPotion)
            {
                inventario.Remove(armaEquipada);
                armaEquipada = null;
            }
        }

        /// <summary>
        ///  escolhe a direção que irá se movimentar, passa as bordas como parametro para comparação
        /// </summary>
        internal void Mover(Direction direcao)
        {
           
            localizacao = Move(direcao, jogo.Bordas);

            if (!jogo.LocazicaoArmas.FoiPega)
            {
                if (Perto(jogo.LocazicaoArmas.Localizacao, 25))
                {
                    inventario.Add(jogo.LocazicaoArmas);
                    jogo.LocazicaoArmas.PegarArma();
                }
            }
        }


    }
}
