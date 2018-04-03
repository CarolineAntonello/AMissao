using AMissao.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMissao
{
    public partial class FormPricipal : Form
    {
        private Game _jogo;
        Control _controle = new Control();
        private Random random = new Random();

        public FormPricipal()
        {
            InitializeComponent();

        }


        private void UpdateCharacters()
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            NovoJogo();
        }

        public void NovoJogo()
        {
            _jogo = new Game(new Rectangle(78, 57, 420, 155));

            _jogo.NovoNivel(random);

            Atualizar();
        }

        public void Atualizar()
        {
            pbxJogador.Location = _jogo.LocalizacaoJogador;
            lblPontosJogador.Text = _jogo.PontoDanoJogador.ToString();
            lblNivelNumero.Text = _jogo.Nivel.ToString();

            bool MostraMorcego = false;
            bool MostraFantasma = false;
            bool MostraSeifador = false;

            int inimigosAparecendo = 0;

            ///Verifica na lista de inimigos, se ele contém, ele recebe true
            foreach (Enemy inimigo in _jogo.Inimigos)
            {
                if (inimigo is Morcego)
                {
                    pbxMorcego.Location = inimigo.localizacao;
                    lblPontosMorcego.Text = inimigo.PontoDeDano.ToString();
                    if (inimigo.PontoDeDano > 0)
                    {
                        MostraMorcego = true;
                        inimigosAparecendo++;
                    }
                }
                else if (inimigo is Fantasma)
                {
                    pbxFantasma.Location = inimigo.localizacao;
                    lblPontosFantasma.Text = inimigo.PontoDeDano.ToString();
                    if (inimigo.PontoDeDano > 0)
                    {
                        MostraFantasma = true;
                        inimigosAparecendo++;
                    }
                }
                else if (inimigo is Seifador)
                {
                    pbxSeifador.Location = inimigo.localizacao;
                    lblPontosSeifador.Text = inimigo.PontoDeDano.ToString();
                    if (inimigo.PontoDeDano > 0)
                    {
                        MostraSeifador = true;
                        inimigosAparecendo++;
                    }
                }
                else
                {
                    continue;
                }
            }

            ///Se algum inimigo foi morto transformo o inimigo em invisible. 
            switch (MostraMorcego)
            {
                case true:
                    pbxMorcego.Visible = true;
                    break;
                case false:
                    pbxMorcego.Visible = false;
                    pbxMorcego.Text = String.Empty;
                    break;
            }

            switch (MostraFantasma)
            {
                case true:
                    pbxFantasma.Visible = true;
                    break;
                case false:
                    pbxFantasma.Visible = false;
                    pbxFantasma.Text = String.Empty;
                    break;
            }

            switch (MostraSeifador)
            {
                case true:
                    pbxSeifador.Visible = true;
                    break;
                case false:
                    pbxSeifador.Visible = false;
                    pbxSeifador.Text = String.Empty;
                    break;
            }

            PictureBoxFalse();

            ArmaNaSala();

            AtualizaPictureBox();

            if (_jogo.PontoDanoJogador <= 0)
            {
                FormMorreu morte = new FormMorreu();
                morte.ShowDialog();
                NovoJogo();

            }
            if (inimigosAparecendo < 1 && _jogo.Nivel < 8)
            {
                _jogo.NovoNivel(random);
                Atualizar();
            }
            if (_jogo.Nivel > 7)
            {
                FormGanhou ganhou = new FormGanhou();
                ganhou.ShowDialog();
                NovoJogo();
            }
        }


        public void AtualizaPictureBox()
        {
            pbxInventario1.Visible = false;
            pbxInventario1.Enabled = false;
            pbxInventario2.Visible = false;
            pbxInventario2.Enabled = false;
            pbxInventario3.Visible = false;
            pbxInventario3.Enabled = false;
            pbxInventario4.Visible = false;
            pbxInventario4.Enabled = false;
            pbxInventario5.Visible = false;
            pbxInventario5.Enabled = false;

            if (_jogo.ChecarInventario("Espada"))
            {
                pbxInventario1.Visible = true;
                pbxInventario1.Enabled = true;
                pbxInventario1.Image = pbxEspada.Image;

            }
            if (_jogo.ChecarInventario("Arco"))
            {
                pbxInventario2.Visible = true;
                pbxInventario2.Enabled = true;
                pbxInventario2.Image = pbxArco.Image;
            }
            if (_jogo.ChecarInventario("Machado"))
            {
                pbxInventario3.Visible = true;
                pbxInventario3.Enabled = true;
                pbxInventario3.Image = pbxMachado.Image;
            }
            if (_jogo.ChecarInventario("Pocao Azul"))
            {
                pbxInventario4.Visible = true;
                pbxInventario4.Enabled = true;
                pbxInventario4.Image = pbxPocaoAzul.Image;
            }
            if (_jogo.ChecarInventario("Pocao Vermelha"))
            {
                pbxInventario5.Visible = true;
                pbxInventario5.Enabled = true;
                pbxInventario5.Image = pbxPocaoVermelha.Image;
            }
            _controle.Location = _jogo.LocazicaoArmas.localizacao;
            if (_jogo.LocazicaoArmas.FoiPega)
                _controle.Visible = false;
            else
                _controle.Visible = true;

        }


        #region Ação picture Box
        private void pbxInventario1_Click(object sender, EventArgs e)
        {
            _jogo.Equipar("Espada");
            pbxInventario1.BorderStyle = BorderStyle.FixedSingle;
            pbxInventario2.BorderStyle = BorderStyle.None;
            pbxInventario3.BorderStyle = BorderStyle.None;
            pbxInventario4.BorderStyle = BorderStyle.None;
            pbxInventario5.BorderStyle = BorderStyle.None;
        }


        private void pbxInventario2_Click(object sender, EventArgs e)
        {
            _jogo.Equipar("Arco");
            pbxInventario2.BorderStyle = BorderStyle.FixedSingle;
            pbxInventario1.BorderStyle = BorderStyle.None;
            pbxInventario3.BorderStyle = BorderStyle.None;
            pbxInventario4.BorderStyle = BorderStyle.None;
            pbxInventario5.BorderStyle = BorderStyle.None;
        }


        private void pbxInventario3_Click(object sender, EventArgs e)
        {
            _jogo.Equipar("Machado");
            pbxInventario3.BorderStyle = BorderStyle.FixedSingle;
            pbxInventario1.BorderStyle = BorderStyle.None;
            pbxInventario2.BorderStyle = BorderStyle.None;
            pbxInventario4.BorderStyle = BorderStyle.None;
            pbxInventario5.BorderStyle = BorderStyle.None;
        }


        private void pbxInventario4_Click(object sender, EventArgs e)
        {
            _jogo.Equipar("Pocao Azul");
            pbxInventario4.BorderStyle = BorderStyle.FixedSingle;
            pbxInventario1.BorderStyle = BorderStyle.None;
            pbxInventario2.BorderStyle = BorderStyle.None;
            pbxInventario3.BorderStyle = BorderStyle.None;
            pbxInventario5.BorderStyle = BorderStyle.None;
        }
        

        private void pbxInventario5_Click(object sender, EventArgs e)
        {
            _jogo.Equipar("Pocao Vermelha");
            pbxInventario5.BorderStyle = BorderStyle.FixedSingle;
            pbxInventario1.BorderStyle = BorderStyle.None;
            pbxInventario2.BorderStyle = BorderStyle.None;
            pbxInventario3.BorderStyle = BorderStyle.None;
            pbxInventario4.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Movimentar
        private void Movimentar(Direction direcao)
        {
            _jogo.Move(direcao, random);
            Atualizar();
        }
        
        private void btnMovimentoParaCima_Click(object sender, EventArgs e)
        {
            Movimentar(Direction.Cima);
        }

        private void btnMovimentoParaBaixo_Click(object sender, EventArgs e)
        {
            Movimentar(Direction.Baixo);
        }

        private void btnMovimentoEsquerda_Click(object sender, EventArgs e)
        {
            Movimentar(Direction.Esquerda);
        }

        private void btnMovimentoDireita_Click(object sender, EventArgs e)
        {
            Movimentar(Direction.Direita);
        }
        #endregion

        #region Atacar
        private void Atacar(Direction direcao)
        {
            try
            {
                _jogo.Atacar(direcao, random);
                Atualizar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione uma arma!");
            }
        }

        private void btnAtaqueParaCima_Click(object sender, EventArgs e)
        {
            Atacar(Direction.Cima);
        }

        private void btnAtaqueParaBaixo_Click(object sender, EventArgs e)
        {
            Atacar(Direction.Baixo);
        }

        private void btnAtaqueEsquerda_Click(object sender, EventArgs e)
        {
            Atacar(Direction.Esquerda);
        }

        private void btnAtaqueDireita_Click(object sender, EventArgs e)
        {
            Atacar(Direction.Direita);
        }
        #endregion

        private void PictureBoxFalse()
        {
            pbxEspada.Visible = false;
            pbxArco.Visible = false;
            pbxPocaoVermelha.Visible = false;
            pbxPocaoAzul.Visible = false;
            pbxMachado.Visible = false;
        }

        private void ArmaNaSala()
        {
            switch (_jogo.LocazicaoArmas.Nome)
            {
                case "Espada":
                    _controle = pbxEspada;
                    break;
                case "Arco":
                    _controle = pbxArco;
                    break;
                case "Pocao Vermelha":
                    _controle = pbxPocaoVermelha;
                    break;
                case "Pocao Azul":
                    _controle = pbxPocaoAzul;
                    break;
                case "Machado":
                    _controle = pbxMachado;
                    break;
            }
        }
    }
}
