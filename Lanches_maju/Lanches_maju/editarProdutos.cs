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
    public partial class editarProdutos : Form
    {
        public editarProdutos()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT id_cliente, nome, telefone FROM tb_clientes";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosCliente = new DataTable();
                        dadosCliente.Load(reader);

                        dgvCliente.DataSource = dadosCliente;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes" + ex.Message);
            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {

                int carroID = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["id_cliente"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            consulta.Open();

                            string listagem = "DELETE FROM tb_clientes WHERE id_cliente = @id_cliente";


                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_cliente", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente.");
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
