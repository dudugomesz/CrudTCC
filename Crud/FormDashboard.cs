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
using Crud.UtilConexao;
using Crud.Util;
using System.Windows.Forms.DataVisualization.Charting;



namespace Crud
{
    public partial class FormDashboard : Form
    {
        int idUsuario;
        string nomeUsuario;
        string perfilUsuario;
        public FormDashboard(int id, string nome, string perfil)
        {
            InitializeComponent();
            idUsuario = id;
            nomeUsuario = nome;
            perfilUsuario = perfil;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        // Função para carregar vendas por mês
        private void CarregarVendasPorMes()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = @"
                SELECT DATE_FORMAT(data_venda, '%Y-%m') AS mes, 
                       SUM(valor_total) AS faturamento
                FROM vendas
                WHERE data_venda BETWEEN @inicio AND @fim
                GROUP BY mes;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@inicio", dtInicio.Value);
                cmd.Parameters.AddWithValue("@fim", dtFim.Value);

                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                chartVendasMes.Series.Clear();
                Series serie = new Series("Faturamento");
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;
                serie.LabelFormat = "C2";

                while (dr.Read())
                {
                    serie.Points.AddXY(dr["mes"].ToString(), dr["faturamento"]);
                }

                chartVendasMes.Series.Add(serie);

                chartVendasMes.ChartAreas[0].AxisX.Interval = 1;
                chartVendasMes.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }
        }
        // Função para carregar as peças mais vendidas
        private void CarregarTopPecas()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = @"
                SELECT p.nome, SUM(iv.quantidade) AS total
                FROM itens_venda iv
                JOIN pecas p ON p.id_peca = iv.id_peca
                JOIN vendas v ON v.id_venda = iv.id_venda
                WHERE v.data_venda BETWEEN @inicio AND @fim
                GROUP BY p.nome
                ORDER BY total DESC
                LIMIT 5;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@inicio", dtInicio.Value);
                cmd.Parameters.AddWithValue("@fim", dtFim.Value);

                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                chartTopPecas.Series.Clear();
                Series serie = new Series("Peças");
                serie.ChartType = SeriesChartType.Pie;
                serie.IsValueShownAsLabel = true;

                while (dr.Read())
                {
                    serie.Points.AddXY(dr["nome"].ToString(), dr["total"]);
                }

                chartTopPecas.Series.Add(serie);
            }
        }

        // Função para carregar vendas por vendedor
        private void CarregarVendasPorVendedor()
        {
            using (MySqlConnection con = Conexao.GetConexao())
            {
                string sql = @"
                SELECT u.nome AS vendedor,
                       COUNT(v.id_venda) AS total_vendas
                FROM vendas v
                JOIN usuarios u ON u.id_usuario = v.id_vendedor
                WHERE v.data_venda BETWEEN @inicio AND @fim
                GROUP BY vendedor;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@inicio", dtInicio.Value);
                cmd.Parameters.AddWithValue("@fim", dtFim.Value);

                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                chartVendedor.Series.Clear();
                Series serie = new Series("Vendas");
                serie.ChartType = SeriesChartType.Bar;
                serie.IsValueShownAsLabel = true;

                while (dr.Read())
                {
                    serie.Points.AddXY(dr["vendedor"].ToString(), dr["total_vendas"]);
                }

                chartVendedor.Series.Add(serie);
                chartVendedor.ChartAreas[0].AxisY.Interval = 1;
            }
        }



        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal(idUsuario, nomeUsuario, perfilUsuario);
            menu.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gerarRelatorio_Click(object sender, EventArgs e)
        {
            CarregarVendasPorMes();
            CarregarTopPecas();
            CarregarVendasPorVendedor();
        }

      
            
    }
}
