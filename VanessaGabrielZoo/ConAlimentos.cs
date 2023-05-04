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
    public partial class ConAlimentos : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblalimentos;
        private string strsql, strconex;

        public ConAlimentos()
        {
            InitializeComponent();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            strconex = "data source = (local); initial catalog = Zoologico; integrated security = sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblalimentos = new DataTable();

            strsql = $"select Alimento, Descricao from Animais a Inner Join Alimentos l on a.codalimento = l.codalimento where Animal = '{txtanimal.Text}'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblalimentos);

            grade.DataSource = tblalimentos;
        }
    }
}
