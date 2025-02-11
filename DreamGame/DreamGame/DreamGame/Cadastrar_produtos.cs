using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamGame
{
    public partial class Cadastrar_produtos : Form
    {
        public Cadastrar_produtos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            maskedTextBoxtamanho.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxNomeCompleto.Focus();
        }
    }
}
