using Crud.UtilConexao;
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

namespace Crud
{
    public partial class FormFornecedores : Form
    {


        int idUsuario;
        string nomeUsuario;
        string perfilUsuario;

        int idSelecionado = 0;
        public FormFornecedores(int id, string nome, string perfil)
        {
            InitializeComponent();

            idUsuario = id;
            nomeUsuario = nome;
            perfilUsuario = perfil;
        }
        
        private void FormFornecedores_Load(object sender, EventArgs e)
        {

            DgvFornecedores.AllowUserToAddRows = false;
            DgvFornecedores.ReadOnly = true;
            DgvFornecedores.MultiSelect = false;
            DgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CarregarFornecedores();
        }
        //Método para carregar os fornecedores no DataGridView
        private void CarregarFornecedores()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "SELECT id_fornecedor, nome, cnpj, telefone, email, endereco " +
                    "FROM fornecedor";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable tabela = new DataTable();
                da.Fill(tabela);

                DgvFornecedores.DataSource = tabela;
            }
        }

        //Método para limpar os campos do formulário
        private void LimparCampos()
        {
            txtNome_Fornecedores.Clear();
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            idSelecionado = 0;
        }

        //Evento de clique na célula do DataGridView para selecionar um fornecedor
        private void DgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = DgvFornecedores.Rows[e.RowIndex];

            if (linha.Cells["id_fornecedor"].Value == null || linha.Cells["id_fornecedor"].Value == DBNull.Value)
                return;

            idSelecionado = Convert.ToInt32(linha.Cells["id_fornecedor"].Value);

            txtNome_Fornecedores.Text = linha.Cells["nome"].Value?.ToString() ?? "";
            txtCNPJ.Text = linha.Cells["cnpj"].Value?.ToString() ?? "";
            txtTelefone.Text = linha.Cells["telefone"].Value?.ToString() ?? "";
            txtEmail.Text = linha.Cells["email"].Value?.ToString() ?? "";
            txtEndereço.Text = linha.Cells["endereco"].Value?.ToString() ?? "";
        }

        //Evento de clique no botão salvar para adicionar um novo fornecedor
        private void btn_salvar_fornecedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome_Fornecedores.Text))
            {
                MessageBox.Show("O nome do fornecedor é obrigatório!");
                return;
            }

            try
            {
                using (MySqlConnection con = Conexao.GetConexao())
                {
                    string sql =
                        "INSERT INTO fornecedor (nome, cnpj, telefone, email, endereco) " +
                        "VALUES (@nome, @cnpj, @telefone, @email, @endereco)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", txtNome_Fornecedores.Text);
                    cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                CarregarFornecedores();
                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar: " + erro.Message);
            }




        }

        private void btn_read_fornecedores_Click(object sender, EventArgs e)
        {
            CarregarFornecedores();
            LimparCampos();
        }

        private void btn_editar_fornecedor_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
                return;
            }

            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "UPDATE fornecedor SET nome=@nome, cnpj=@cnpj, telefone=@telefone, email=@email, endereco=@endereco " +
                    "WHERE id_fornecedor=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome_Fornecedores.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@id", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Fornecedor atualizado!");
            CarregarFornecedores();
            LimparCampos();
        }

        
        //metodo para verificar se o fornecedor possui peças vinculadas
        private bool FornecedorPossuiPecas(int idFornecedor)
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "SELECT COUNT(*) FROM pecas WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idFornecedor);
                con.Open();
                int qtd = Convert.ToInt32(cmd.ExecuteScalar());
                return qtd > 0;
            }
        }

        //Evento de clique no botão excluir para remover um fornecedor

        private void btn_excluir_fornecedor_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
                return;
            }

            if (FornecedorPossuiPecas(idSelecionado))
            {
                MessageBox.Show("Não é possível excluir este fornecedor pois existem peças vinculadas a ele.");
                return;
            }

            if (MessageBox.Show("Confirmar exclusão do fornecedor?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "DELETE FROM fornecedor WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Fornecedor excluído com sucesso!");
            CarregarFornecedores();
            LimparCampos();

        }
    }
}
