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

    public partial class FormPagamento : Form
    {

        private int idUsuarioLogado;
        public FormPagamento(int vendaId, int usuarioId)
        {
            InitializeComponent();
            
            idUsuarioLogado = usuarioId;
        }

       

    


       

        

    }
}
