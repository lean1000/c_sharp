using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lanches_maju
{
    public partial class cadclinte : Form
    {
        public cadclinte()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_produtos (nome, valor, descricao, categoria) VALUES (@nome, @valor, @descricao, @categoria)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNomeProduto.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@descricao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@categoria", comboBoxCategoria.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            textBoxNomeProduto.Text = "";
            maskedTextBoxValor.Text = "";
            richTextBoxDescricao.Text = "";
            comboBoxCategoria.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
