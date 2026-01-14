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
    public partial class FormStatusPedido : Form
    {
        
        public FormStatusPedido()
        {
            InitializeComponent();
            


        }


        private void FormStatusPedido_Load(object sender, EventArgs e)
        {
            dgv_statusPedidos.AllowUserToAddRows = false;
            dgv_statusPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_statusPedidos.MultiSelect = false;
            dgv_statusPedidos.ReadOnly = true;

            cbStatus.Items.Add("TODOS");
            cbStatus.Items.Add("PENDENTE");
            cbStatus.Items.Add("APROVADO");
            cbStatus.Items.Add("REJEITADO");
            cbStatus.SelectedIndex = 0;

            CarregarPedidos();
        }

        private void CarregarPedidos(string status = "")
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql =
                    "SELECT pc.id_pedido AS 'ID', " +
                    "u.nome AS 'Responsável', " +
                    "f.nome AS 'Fornecedor', " +
                    "pc.data_pedido AS 'Data', " +
                    "GROUP_CONCAT(p.nome SEPARATOR ', ') AS 'Peças', " +
                    "pc.status AS 'Status' " +
                    "FROM pedido_compra pc " +
                    "JOIN usuarios u ON pc.id_responsavel_estoque = u.id_usuario " +
                    "JOIN fornecedor f ON pc.id_fornecedor = f.id_fornecedor " +
                    "JOIN itens_pedido_compra ip ON ip.id_pedido = pc.id_pedido " +
                    "JOIN pecas p ON p.id_peca = ip.id_peca ";

                if (status != "" && status != "TODOS")
                {
                    sql += "WHERE pc.status = @status ";
                }

                sql += "GROUP BY pc.id_pedido";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                if (status != "" && status != "TODOS")
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);

                dgv_statusPedidos.DataSource = tabela;

                if (dgv_statusPedidos.Columns.Contains("ID"))
                    dgv_statusPedidos.Columns["ID"].Width = 50;
            }
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            string status = cbStatus.SelectedItem.ToString();
            CarregarPedidos(status);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
