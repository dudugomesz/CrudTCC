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
    public partial class FormRelatorios : Form
    {
        int idUsuario;
        string nomeUsuario;
        string perfilUsuario;
        public FormRelatorios(int id, string nome, string perfil)
        {
            InitializeComponent();
            idUsuario = id;
            nomeUsuario = nome;
            perfilUsuario = perfil;
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            CarregarVendedores();
            CarregarStatus();
        }
        //função para carregar os vendedores no combo box
        private void CarregarVendedores()
        {
            MySqlConnection con = Conexao.GetConexao();

            string sql = "SELECT id_usuario, nome FROM usuarios WHERE perfil='VENDEDOR'";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            cmbVendedor.Items.Clear();
            cmbVendedor.Items.Add("Todos");

            while (dr.Read())
            {
                cmbVendedor.Items.Add(dr["id_usuario"] + " - " + dr["nome"]);
            }

            dr.Close();
            con.Close();

            cmbVendedor.SelectedIndex = 0;
        }

        //função para carregar os status no combo box
        private void CarregarStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Todos");
            cmbStatus.Items.Add("ABERTA");
            cmbStatus.Items.Add("FINALIZADA");
            cmbStatus.Items.Add("CANCELADA");
            cmbStatus.SelectedIndex = 0;
        }

        //função para buscar o relatório
        private void BuscarRelatorio()
        {
            MySqlConnection con = Conexao.GetConexao();

            string sql = @"SELECT v.id_venda,
                          u.nome AS vendedor,
                          v.data_venda,
                          v.valor_total,
                          v.desconto_aplicado,
                          v.status
                   FROM vendas v
                   INNER JOIN usuarios u ON u.id_usuario = v.id_vendedor
                   WHERE v.data_venda BETWEEN @inicio AND @fim";

            // Filtrar por vendedor
            if (cmbVendedor.SelectedIndex > 0)
            {
                string idVend = cmbVendedor.SelectedItem.ToString().Split('-')[0].Trim();
                sql += " AND v.id_vendedor = " + idVend;
            }

            // Filtrar por status
            if (cmbStatus.SelectedIndex > 0)
            {
                sql += " AND v.status = '" + cmbStatus.SelectedItem.ToString() + "'";
            }

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@inicio", dataInicio.Value.Date);
            cmd.Parameters.AddWithValue("@fim", dataFim.Value.Date);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            dgv_relatorios.DataSource = dt;
        }


        //botão para buscar o relatório
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRelatorio();
        }

        //botão para limpar os filtros
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataInicio.Value = DateTime.Now;
            dataFim.Value = DateTime.Now;
            cmbVendedor.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            dgv_relatorios.DataSource = null;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal(idUsuario, nomeUsuario, perfilUsuario);
            menu.Show();
            this.Close();
        }
    }
}
