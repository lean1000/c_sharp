using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lanches_maju
{
    public partial class cadproduto : Form
    {
        public cadproduto()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;
            string email = textBoxEmail.Text;

            if (ValidarCPF(cpf) && ValidarEmail(email))
            {
                labelResultadoCpf.Text = "Cadastro realizado com sucesso!";
                labelResultadoCpf.ForeColor = System.Drawing.Color.Green;

                labelResultadoEmail.Text = "";

                // Conexão com o banco de dados
                string conexaoString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";
                string query = "INSERT INTO tb_clientes (nome, email, senha, cep, cpf, numero, Telefone) VALUES (@nome, @email, @senha, @cep, @cpf, @numero, @telefone)";

                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    try
                    {
                        conexao.Open();

                        using (MySqlCommand comando = new MySqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@nome", textBoxNomeCliente.Text);
                            comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                            comando.Parameters.AddWithValue("@email", textBoxEmail.Text);
                            comando.Parameters.AddWithValue("@cep", maskedTextBoxCep.Text);
                            comando.Parameters.AddWithValue("@cpf", maskedTextBoxCPF.Text);
                            comando.Parameters.AddWithValue("@numero", maskedTextBoxNumero.Text);
                            comando.Parameters.AddWithValue("@telefone", maskedTextBoxTelefone.Text);

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
            else
            {
                if (!ValidarCPF(cpf))
                {
                    labelResultadoCpf.Text = "CPF inválido!";
                    labelResultadoCpf.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    labelResultadoCpf.Text = "";
                }

                if (!ValidarEmail(email))
                {
                    labelResultadoEmail.Text = "E-mail inválido!";
                    labelResultadoEmail.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    labelResultadoEmail.Text = "";
                }
            }
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.All(c => c == cpf[0]))
                return false;

            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += (cpf[i] - '0') * (10 - i);
            }
            int resto1 = soma1 % 11;
            int digito1 = (resto1 < 2) ? 0 : 11 - resto1;
            if (digito1 != (cpf[9] - '0'))
                return false;

            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += (cpf[i] - '0') * (11 - i);
            }
            int resto2 = soma2 % 11;
            int digito2 = (resto2 < 2) ? 0 : 11 - resto2;
            if (digito2 != (cpf[10] - '0'))
                return false;

            return true;
        }

        // Método para validar o e-mail
        public static bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void LimparCampos()
        {
            textBoxNomeCliente.Text = "";
            textBoxSenha.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCep.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxTelefone.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
