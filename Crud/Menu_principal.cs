using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.UtilConexao;

namespace Crud
{
    public partial class Menu_principal : Form
    {
        private int idLogado;
        private string usuarioLogado;
        private string perfilLogado;

        public Menu_principal(int id, string usuario, string perfil)
        {
            InitializeComponent();

            idLogado = id;
            usuarioLogado = usuario;
            perfilLogado = perfil;

            lblUsuario.Text = "Usuário: " + usuarioLogado;
            lblPerfil.Text = "Perfil: " + perfilLogado;

            ControlarPermissoes();
        }
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void ControlarPermissoes()
        {
            if (perfilLogado == "VENDEDOR")
            {
                btn_usuarios.Visible = false;
                
            }

            if (perfilLogado == "ESTOQUE")
            {
                btn_vendas.Visible = false;
            }
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios TelaUser = new FormUsuarios(idLogado, usuarioLogado, perfilLogado);
            TelaUser.ShowDialog();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            FormVendas vendas = new FormVendas(idLogado);
            vendas.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Close();
        }

        private void btn_pecas_Click(object sender, EventArgs e)
        {
            pecas pecas = new pecas(idLogado, usuarioLogado, perfilLogado);
            pecas.ShowDialog();

        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedores fornecedores = new FormFornecedores(idLogado, usuarioLogado, perfilLogado);
            fornecedores.ShowDialog();
        }

        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios relatorios = new FormRelatorios(idLogado, usuarioLogado, perfilLogado);
            relatorios.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard(idLogado, usuarioLogado, perfilLogado);
            dashboard.ShowDialog();
        }
    }
}
