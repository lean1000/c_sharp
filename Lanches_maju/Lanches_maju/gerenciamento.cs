using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanches_maju
{
    public partial class gerenciamento : Form
    {
        public gerenciamento()
        {
            InitializeComponent();
        }

        private void gerenciamento_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadproduto form = new cadproduto();
            form.ShowDialog();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            cadclinte form = new cadclinte();
            form.ShowDialog();
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            editarProdutos form = new editarProdutos();
            form.ShowDialog();
        }

        private void buttonEditarProduto_Click(object sender, EventArgs e)
        {
            editarCliente form = new editarCliente();
            form.ShowDialog();
        }
    }
}
