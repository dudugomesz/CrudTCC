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
    public partial class FormVendas : Form
    {

        private int idUsuarioLogado;
        public FormVendas(int idLogado)
        {
            InitializeComponent();
            idUsuarioLogado = idLogado;
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

            // Configurar grid
            DgvITENS.AllowUserToAddRows = false;
            DgvITENS.ReadOnly = true;
            DgvITENS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Adicionar colunas se não existirem ainda
            if (DgvITENS.Columns.Count == 0)
            {
                DgvITENS.Columns.Add("id_peca", "ID Peça");
                DgvITENS.Columns.Add("nome", "Peça");
                DgvITENS.Columns.Add("preco", "Preço");
                DgvITENS.Columns.Add("quantidade", "Quantidade");
                DgvITENS.Columns.Add("total", "Total");
            }
            CarregarPecas();
        }

        private void LimparVenda()
        {
            DgvITENS.Rows.Clear();
            txtQuantidade.Clear();
            txtDesconto_vendas.Clear();
            txtTotal.Clear();
            txtPreco_venda.Clear();
            cmbPeca.SelectedIndex = -1;
        }


        private void CarregarPecas()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = "SELECT id_peca, nome, preco FROM pecas WHERE ativo = 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(dr);

                cmbPeca.DataSource = tabela;
                cmbPeca.DisplayMember = "nome";
                cmbPeca.ValueMember = "id_peca";
            }
        }

        private void cmbPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeca.SelectedItem == null) return;

            DataRowView drv = (DataRowView)cmbPeca.SelectedItem;
            txtPreco_venda.Text = drv["preco"].ToString();
        }



        // Método para calcular o total da venda
        private void CalcularTotalVenda()
        {
            decimal soma = 0;

            foreach (DataGridViewRow row in DgvITENS.Rows) soma += Convert.ToDecimal(row.Cells[4].Value);
              

            txtTotal.Text = soma.ToString("N2");
        }

        private void btn_add_venda_Click(object sender, EventArgs e)
        {
            if (cmbPeca.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Selecione a peça e informe a quantidade!");
                return;
            }

            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal preco = Convert.ToDecimal(txtPreco_venda.Text);
            decimal total = preco * quantidade;

            DgvITENS.Rows.Add(
                cmbPeca.SelectedValue,
                cmbPeca.Text,
                preco,
                quantidade,
                total
            );

            CalcularTotalVenda();
        }


        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesconto_vendas.Text)) return;

            int desconto = Convert.ToInt32(txtDesconto_vendas.Text);

            if (desconto > descontoMaxPermitido)
            {
                MessageBox.Show($"Desconto máximo permitido é {descontoMaxPermitido}%!");
                txtDesconto_vendas.Text = "0";
            }

            CalcularTotalComDesconto();
        }

        public int descontoMaxPermitido;

        private void CalcularTotalComDesconto()
        {
            decimal total = Convert.ToDecimal(txtTotal.Text);
            decimal desc = Convert.ToDecimal(txtDesconto_vendas.Text);

            decimal valorComDesconto = total - ((desc / 100) * total);

            txtTotal.Text = valorComDesconto.ToString("N2");
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (DgvITENS.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item adicionado!");
                return;
            }

            using (MySqlConnection con = Conexao.GetConexao())
            {
                con.Open();
                MySqlTransaction trans = con.BeginTransaction();

                try
                {
                    // Inserir venda com status ABERTA
                    string sqlVenda =
                        "INSERT INTO vendas (id_vendedor, data_venda, valor_total, desconto_aplicado, status) " +
                        "VALUES (@idVend, @data, @total, @desconto, 'ABERTA')";

                    MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, con, trans);
                    cmdVenda.Parameters.AddWithValue("@idVend", idUsuarioLogado);
                    cmdVenda.Parameters.AddWithValue("@data", DateTime.Now);
                    cmdVenda.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));
                    cmdVenda.Parameters.AddWithValue("@desconto", Convert.ToDecimal(txtDesconto_vendas.Text));
                    cmdVenda.ExecuteNonQuery();

                    int idVenda = (int)cmdVenda.LastInsertedId;

                    // Inserir itens da venda
                    foreach (DataGridViewRow row in DgvITENS.Rows)
                    {
                        string sqlItem =
                            "INSERT INTO itens_venda (id_venda, id_peca, quantidade, preco_unitario) " +
                            "VALUES (@idVenda, @idPeca, @qtd, @preco)";

                        MySqlCommand cmdItem = new MySqlCommand(sqlItem, con, trans);
                        cmdItem.Parameters.AddWithValue("@idVenda", idVenda);
                        cmdItem.Parameters.AddWithValue("@idPeca", row.Cells[0].Value);
                        cmdItem.Parameters.AddWithValue("@qtd", row.Cells[3].Value);
                        cmdItem.Parameters.AddWithValue("@preco", row.Cells[2].Value);
                        cmdItem.ExecuteNonQuery();
                    }

                    trans.Commit();

                    // Abre a tela de pagamento
                    FormPagamento frmPagamento = new FormPagamento(idVenda, idUsuarioLogado);
                    frmPagamento.ShowDialog();

                    LimparVenda();
                }
                catch
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao finalizar venda!");
                }
            }


        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (DgvITENS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            DgvITENS.Rows.RemoveAt(DgvITENS.SelectedRows[0].Index);

            // Recalcula total após remover item
            CalcularTotalVenda();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (DgvITENS.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item para cancelar.");
                return;
            }

            if (MessageBox.Show("Deseja cancelar a venda?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            LimparVenda();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal?",
            "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
