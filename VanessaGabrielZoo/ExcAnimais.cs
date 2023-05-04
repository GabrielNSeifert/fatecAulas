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
    public partial class ExcAnimais : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblanimais;
        private SqlCommand comando;
        private string strsql, strconex;

        public ExcAnimais()
        {
            InitializeComponent();
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            strsql = $"delete from animais where codanimal = '{txtcodanimal.Text}'";

            comando = new SqlCommand(strsql, conexao);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro apagado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            strconex = "data source = (local); initial catalog = Zoologico; integrated security = sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblanimais = new DataTable();

            strsql = "select * from animais where codanimal = '" + txtcodanimal.Text + "'";

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblanimais);

            if (tblanimais.Rows.Count == 1)
            {
                groupBox1.Enabled = false;
                groupBox2.Visible = true;

                txtanimal.Text = tblanimais.Rows[0]["animal"].ToString();
                txtpaisorigem.Text = tblanimais.Rows[0]["paisorigem"].ToString();
                txtlocalizacao.Text = tblanimais.Rows[0]["localizacao"].ToString();
                txtcodalimento.Text = tblanimais.Rows[0]["codalimento"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
