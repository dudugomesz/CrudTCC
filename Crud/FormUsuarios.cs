using Crud.Util;
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
using static System.Windows.Forms.LinkLabel;



namespace Crud
{



    public partial class FormUsuarios : Form
    {

        int idUsuario;
        string nomeUsuario;
        string perfilUsuario;

        int idUsuarioSelecionado = 0;
        private void CarregarUsuarios()
        {
            MySqlConnection conexao = Conexao.GetConexao();

            string comandoSql =
                "SELECT id_usuario, nome, login, perfil, percentual_desconto_max " +
                "FROM usuarios";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSql, conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);

            dgvUsuarios.DataSource = tabela;

            dgvUsuarios.Columns["id_usuario"].Visible = false;
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;


            CarregarUsuarios();
        }
        public FormUsuarios(int id, string nome, string perfil)
        {
            InitializeComponent();
            idUsuario = id;
            nomeUsuario = nome;
            perfilUsuario = perfil;

        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtDesconto.Clear();
            cmbPerfil.SelectedIndex = -1;

            idUsuarioSelecionado = 0;
        }


        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return; // Fazendo uma proteção contra clique no cabeçalho.

            var linha = dgvUsuarios.Rows[e.RowIndex]; // pegando a linha clicada

            
            if (linha.Cells["id_usuario"].Value == null || linha.Cells["id_usuario"].Value == DBNull.Value) //testando se o valor é nulo
            return;

            idUsuarioSelecionado = Convert.ToInt32(linha.Cells["id_usuario"].Value); //convertendo o valor para int e atribuindo à variável

            // preenchendo os campos do formulário com os dados da linha selecionada
            txtNome.Text = linha.Cells["nome"].Value?.ToString() ?? "";
            txtLogin.Text = linha.Cells["login"].Value?.ToString() ?? "";
            cmbPerfil.Text = linha.Cells["perfil"].Value?.ToString() ?? "";
            txtDesconto.Text = linha.Cells["percentual_desconto_max"].Value?.ToString() ?? "";

            //?. -- se o valor for null, o .ToString() não executa (evita erro)
            //?? "" -- se for null, coloca "" (string vazia)
        }






        private void btn_salvar_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)  ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(cmbPerfil.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            try
            {
                using (MySqlConnection con = Conexao.GetConexao())
                {
                    string sql =
                        "INSERT INTO usuarios (nome, login, senha, perfil, percentual_desconto_max) " +
                        "VALUES (@nome, @login, @senha, @perfil, @desconto)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", Criptografia.GerarSHA256(txtSenha.Text));
                    cmd.Parameters.AddWithValue("@perfil", cmbPerfil.Text);
                    cmd.Parameters.AddWithValue("@desconto", Convert.ToInt32(txtDesconto.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário cadastrado com sucesso!");
                CarregarUsuarios();
                LimparCampos();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao salvar: " + erro.Message);
            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_editar_user_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = Conexao.GetConexao();

            string comandoSql =
                "UPDATE usuarios " +
                "SET nome = @nome, login = @login, perfil = @perfil, percentual_desconto_max = @desconto " +
                "WHERE id_usuario = @id";

            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@login", txtLogin.Text);
            comando.Parameters.AddWithValue("@perfil", cmbPerfil.Text);
            comando.Parameters.AddWithValue("@desconto", Convert.ToInt32(txtDesconto.Text));
            comando.Parameters.AddWithValue("@id", idUsuarioSelecionado);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Usuário atualizado.");
            LimparCampos();
            CarregarUsuarios();
        }

        private void btn_excluir_user_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexao.GetConexao();

            string sql = "DELETE FROM usuarios WHERE id_usuario = @id";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", idUsuarioSelecionado);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Usuário excluído!");

            CarregarUsuarios();
            LimparCampos();
        }

        private void btn_read_user_Click(object sender, EventArgs e)
        {

            MySqlConnection con = Conexao.GetConexao();

            string sql = "SELECT id_usuario, nome, login, perfil, percentual_desconto_max FROM usuarios";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvUsuarios.DataSource = dt;
        }

        private void btn_voltar_Frmuser_Click(object sender, EventArgs e)
        {
            Menu_principal menu_Principal = new Menu_principal();
            menu_Principal.Show();
           
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
