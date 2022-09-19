using Sistema_Escolar.Mapeador;
using Sistema_Escolar.Negocio;
using Sistema_Escolar.Processo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_Escolar
{
    public partial class formEditar : Form
    {

        
        ProcessoAluno processoAluno = new ProcessoAluno();
        DataTable dt = new DataTable(); 

        public formEditar()
        {
            InitializeComponent();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formHome home = new formHome();
            this.Close();
            home.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno()
            {
                Matricula = txbMatricula.Text,
                Nome = txbNome.Text,
                CPF = txbCPF.Text,
                CEP = txbCEP.Text,
                Endereco = txbEndereco.Text,
                Telefone = txbTelefone.Text,
                Email = txbEmail.Text,
                Sexo = cbxSexo.Text,
                Nacionalidade = cbxNacionalidade.Text,
                Naturalidade = cbxNaturalidade.Text,
                Nascimento = txbDataNascimento.Text,
                Contato = txbContatoTelefone.Text,
                ContatoNome = txbContatoNome.Text,
                Obs = txbObs.Text,

            };
            processoAluno.AlteraAluno(aluno);

        }

        private void formEditar_Load(object sender, EventArgs e)
        {
            MapeadorDeAluno mapeadorDeAluno = new MapeadorDeAluno();
            var sql = $"SELECT * FROM ALUNOS A INNER JOIN CIDADES C ON A.ALUNACIONAL = C.CODCIDADE WHERE ALUNOME LIKE '{aluno.Nome}'";
            dt = mapeadorDeAluno.ObtemAlunos();

            txbMatricula.Text = dt.Rows[0].ItemArray[0].ToString();
            txbNome.Text = dt.Rows[0].ItemArray[1].ToString();

            //CPF = txbCPF.Text,
            //CEP = txbCEP.Text,
            //Endereco = txbEndereco.Text,
            //Telefone = txbTelefone.Text,
            //Email = txbEmail.Text,
            //Sexo = cbxSexo.Text,
            //Nacionalidade = cbxNacionalidade.Text,
            //Naturalidade = cbxNaturalidade.Text,
            //Nascimento = txbDataNascimento.Text,
            //Contato = txbContatoTelefone.Text,
            //ContatoNome = txbContatoNome.Text,
            //Obs = txbObs.Text,
        }
    }
}
