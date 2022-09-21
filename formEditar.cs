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
        Aluno aluno = new Aluno();

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
                Nacionalidade = cbxCidade.Text,
                Naturalidade = cbxNaturalidade.Text,
                Nascimento = txbDataNascimento.Text,
                Contato = txbContatoTelefone.Text,
                ContatoNome = txbContatoNome.Text,
                Obs = txbObs.Text,

            };
            processoAluno.AlteraAluno(aluno);

        }

        public void formEditar_Load(object sender, EventArgs e)
        {
            
            //MapeadorDeAluno mapeadorDeAluno = new MapeadorDeAluno();
            //dt = mapeadorDeAluno.ObtemAlunos();

            //txbMatricula.Text = dt.Rows[0].ItemArray[0].ToString();
            //txbNome.Text = dt.Rows[0].ItemArray[1].ToString();
            //txbCPF.Text = dt.Rows[0].ItemArray[2].ToString();
            //txbEndereco.Text = dt.Rows[0].ItemArray[3].ToString();
            //txbEmail.Text = dt.Rows[0].ItemArray[4].ToString();
            //cbxSexo.Text = dt.Rows[0].ItemArray[5].ToString();
            //txbNacionalidade.Text = dt.Rows[0].ItemArray[6].ToString();
            //txbNaturalidade.Text = dt.Rows[0].ItemArray[7].ToString();
            //txbDataNascimento.Text = dt.Rows[0].ItemArray[8].ToString();
            //txbTelefone.Text = dt.Rows[0].ItemArray[9].ToString();
            //txbCEP.Text = dt.Rows[0].ItemArray[10].ToString();
            //txbContatoTelefone.Text = dt.Rows[0].ItemArray[11].ToString();
            //txbContatoNome.Text = dt.Rows[0].ItemArray[12].ToString();
            //txbObs.Text = dt.Rows[0].ItemArray[13].ToString();
        }
    }
}
