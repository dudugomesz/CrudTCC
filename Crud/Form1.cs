using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Crud.Util;
using Crud.UtilConexao;

namespace Crud
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void button_login_Click(object sender, EventArgs e)
        {
            string login = TxtUsuario.Text;
            string senhaHash = Criptografia.GerarSHA256(TxtSenha.Text);

            MySqlConnection con = Conexao.GetConexao();
            string comandoSql =
            "SELECT id_usuario, nome, perfil " +
            "FROM usuarios " +
            "WHERE login = @login " +
            "AND senha = @senha";

            MySqlCommand cmd = new MySqlCommand(comandoSql, con);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senhaHash);

            con.Open();
            MySqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.Read())
            {
                int idUsuario = Convert.ToInt32(leitor["id_usuario"]);
                string nomeUsuario = leitor["nome"].ToString();
                string perfilUsuario = leitor["perfil"].ToString();

                Menu_principal menu = new Menu_principal(idUsuario, nomeUsuario, perfilUsuario);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos.");
            }

            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
