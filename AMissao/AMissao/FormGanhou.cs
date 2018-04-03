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
    public partial class FormGanhou : Form
    {
        public FormGanhou()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNovoJogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
