using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            textBoxTitulo.Text = "";
            comboBoxAvaliacao.Text = "";
            maskedTextBoxTamanho.Text = "";
            richTextBoxDescricao.Text = "";
            maskedTextBoxValor.Text = "";
            textBoxDesenvolvedor.Text = "";
            comboBoxGenero.Focus();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=db_dreamggame; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_game (titulo, avaliacao, tamanho, descriacao, valor, desenvolvedor, genero) VALUES (@titulo, @avaliacao, @tamanho, @descriacao, @valor, @desenvolvedor, @genero)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@avaliacao", comboBoxAvaliacao.Text);
                        comando.Parameters.AddWithValue("@tamanho", maskedTextBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@descriacao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@desenvolvedor", textBoxDesenvolvedor.Text);
                        comando.Parameters.AddWithValue("@genero", comboBoxGenero.Text);

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
    }
}
