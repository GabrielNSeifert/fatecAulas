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
    public partial class AltAlimentos : Form
    {

        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblalimentos;
        private SqlCommand comando;
        private string strsql, strconex;

        public AltAlimentos()
        {
            InitializeComponent();
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            strsql = $"update alimentos set alimento = '{txtalimento.Text}', descricao = '{txtdescricao.Text}' where codalimento = '{txtcodalimento.Text}'";

            comando = new SqlCommand(strsql, conexao);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro alterado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            strconex = "data source = (local); initial catalog = Zoologico; integrated security = sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblalimentos = new DataTable();

            strsql = $"select * from Alimentos where codalimento = '{txtcodalimento.Text}'";

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblalimentos);

            if (tblalimentos.Rows.Count == 1)
            {
                groupBox1.Enabled = false;
                groupBox2.Visible = true;

                txtalimento.Text = tblalimentos.Rows[0]["alimento"].ToString();
                txtdescricao.Text = tblalimentos.Rows[0]["descricao"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupBox1.Enabled = true;
            }
        }

        private void AltAlimentos_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }
    }
}
