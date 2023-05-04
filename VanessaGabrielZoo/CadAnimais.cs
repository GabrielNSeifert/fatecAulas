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
    public partial class CadAnimais : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadAnimais()
        {
            InitializeComponent();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            try
            {

                strconex = " data source = (local); initial catalog = Zoologico; integrated security = sspi;";
                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = $"insert into Animais (animal, paisorigem, localizacao, codalimento) values ('{txtanimal.Text}','{txtpaisorigem.Text}', '{txtlocalizacao.Text}', '{txtcodalimento.Text}')";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Falha no cadastro.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
