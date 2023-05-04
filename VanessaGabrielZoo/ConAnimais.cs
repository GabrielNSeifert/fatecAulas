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

namespace VanessaGabrielZoo
{
    public partial class ConAnimais : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblanimais;
        private string strsql, strconex;

        public ConAnimais()
        {
            InitializeComponent();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            strconex = "data source = (local); initial catalog = Zoologico; integrated security = sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblanimais = new DataTable();

            strsql = $"select * from Animais where localizacao = '{txtlocalizacao.Text}'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblanimais);

            grade.DataSource = tblanimais;
        }
    }
}
