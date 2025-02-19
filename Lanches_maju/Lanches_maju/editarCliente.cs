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

namespace Lanches_maju
{
    public partial class editarCliente : Form
    {
        public editarCliente()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarProdutos_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT id_produto, nome, valor, categoria FROM tb_produtos";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosCliente = new DataTable();
                        dadosCliente.Load(reader);

                        dgvProdutos.DataSource = dadosCliente;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Produtos" + ex.Message);
            }
        }

        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {

                int carroID = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["id_produto"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            consulta.Open();

                            string listagem = "DELETE FROM tb_produtos WHERE id_produto = @id_produto";


                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_produto", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Produto excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o produto.");
                                }
                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um Cliente para excluir");
                }

            }
        }
    }
}
