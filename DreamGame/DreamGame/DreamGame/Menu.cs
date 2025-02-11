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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar_produtos form = new Cadastrar_produtos();
            form.ShowDialog();
        }

        private void Gerenciar_Click(object sender, EventArgs e)
        {
            gerenciar_produtos form = new gerenciar_produtos();
            form.ShowDialog();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
