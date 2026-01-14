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
    public partial class pecas : Form
    {
        int idSelecionado = 0;

        int idUsuario;
        string nomeUsuario;
        string perfilUsuario;
        public pecas(int id, string nome, string perfil)
        {
            InitializeComponent();
            idUsuario = id;
            nomeUsuario = nome;
            perfilUsuario = perfil;
        }

        private void pecas_Load(object sender, EventArgs e)
        {
            DgvPecas.AllowUserToAddRows = false;
            DgvPecas.ReadOnly = true;
            DgvPecas.MultiSelect = false;
            DgvPecas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CarregarFornecedores();
            CarregarPecas();
        }

        private void CarregarFornecedores()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "SELECT id_fornecedor, nome FROM fornecedor";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(dr);

                cmbFornecedor.DataSource = tabela;
                cmbFornecedor.DisplayMember = "nome";
                cmbFornecedor.ValueMember = "id_fornecedor";
            }
        }

        private void LimparCampos()
        {
            txtNome_pecas.Clear();
            txtDescricao_pecas.Clear();
            txtPreco_pecas.Clear();
            cmbFornecedor.SelectedIndex = -1;
            idSelecionado = 0;
        }

        private void CarregarPecas()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "SELECT p.id_peca, p.nome, p.descricao, p.preco, f.nome AS fornecedor " +
                    "FROM pecas p " +
                    "LEFT JOIN fornecedor f ON p.id_fornecedor = f.id_fornecedor " +
                    "WHERE p.ativo = 1";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable tabela = new DataTable();
                da.Fill(tabela);

                DgvPecas.DataSource = tabela;
            }
        }


        private void DgvPecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = DgvPecas    .Rows[e.RowIndex];

            if (linha.Cells["id_peca"].Value == null || linha.Cells["id_peca"].Value == DBNull.Value)
                return;

            idSelecionado = Convert.ToInt32(linha.Cells["id_peca"].Value);

            txtNome_pecas.Text = linha.Cells["nome"].Value?.ToString() ?? "";
            txtDescricao_pecas.Text = linha.Cells["descricao"].Value?.ToString() ?? "";
            txtPreco_pecas.Text = linha.Cells["preco"].Value?.ToString() ?? "";

           
            cmbFornecedor.Text = linha.Cells["fornecedor"].Value?.ToString() ?? ""; // Selecionar fornecedor
        }

        private void btn_salvar_pecas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome_pecas.Text) ||
                string.IsNullOrWhiteSpace(txtPreco_pecas.Text) ||
                cmbFornecedor.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha nome, preço e fornecedor!");
                return;
            }

            try
            {
                using (MySqlConnection con = Conexao.GetConexao())
                {
                    string sql =
                        "INSERT INTO pecas (nome, descricao, preco, id_fornecedor) " +
                        "VALUES (@nome, @descricao, @preco, @fornecedor)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", txtNome_pecas.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao_pecas.Text);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco_pecas.Text));
                    cmd.Parameters.AddWithValue("@fornecedor", cmbFornecedor.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Peça cadastrada com sucesso!");
                CarregarPecas();
                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar: " + erro.Message);
            }
        }


        //metodo para verificar se a peça possui vendas associadas
        private bool PecaPossuiVendas(int idPeca)
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "SELECT COUNT(*) FROM itens_venda WHERE id_peca=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idPeca);
                con.Open();
                int qtd = Convert.ToInt32(cmd.ExecuteScalar());
                return qtd > 0;
            }
        }

        //metodo para excluir peça
        private void btn_excluir_pecas_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma peça.");
                return;
            }

            if (MessageBox.Show("Deseja realmente inativar esta peça?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "UPDATE pecas SET ativo=0 WHERE id_peca=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Peça inativada com sucesso!");
            CarregarPecas();
            LimparCampos();
        }

        private void btn_editar_pecas_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma peça para editar.");
                return;
            }

            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "UPDATE pecas SET nome=@nome, descricao=@descricao, preco=@preco, id_fornecedor=@fornecedor " +
                    "WHERE id_peca=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome_pecas.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao_pecas.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco_pecas.Text));
                cmd.Parameters.AddWithValue("@fornecedor", cmbFornecedor.SelectedValue);
                cmd.Parameters.AddWithValue("@id", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Peça atualizada!");
            CarregarPecas();
            LimparCampos();
        }

        private void btn_read_pecas_Click(object sender, EventArgs e)
        {
            CarregarPecas();
        }

        private void btn_pecas_inativas_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "SELECT p.id_peca, p.nome, p.descricao, p.preco, f.nome AS fornecedor " +
                    "FROM pecas p " +
                    "LEFT JOIN fornecedor f ON p.id_fornecedor = f.id_fornecedor " +
                    "WHERE p.ativo = 0";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable tabela = new DataTable();
                da.Fill(tabela);

                DgvPecas.DataSource = tabela;
            }
        }

        private void btnReativar_peca_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma peça.");
                return;
            }

            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "UPDATE pecas SET ativo=1 WHERE id_peca=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Peça reativada com sucesso!");
            CarregarPecas();
            LimparCampos();
        }
    }
}
