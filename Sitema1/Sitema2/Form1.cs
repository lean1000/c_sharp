using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema2
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }
    }
}
