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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_Escolar
{

    public partial class formEditar : Form
    {
        public string NomeEditar { get; set; }
        public formHome home { get; set; }


        MapeadorDeAluno mapeadorDeAluno = new MapeadorDeAluno();
        ProcessoAluno processoAluno = new ProcessoAluno();
        DataTable dt = new DataTable();

        public formEditar(Aluno aluno)
        {
            InitializeComponent();

            txbMatricula.Text = aluno.Matricula;
            txbNome.Text = aluno.Nome.ToUpper();
            txbCPF.Text = aluno.CPF;
            cbxSexo.Text = aluno.Sexo;
            txbDataNascimento.Text = aluno.Nascimento;
            txbNacionalidade.Text = aluno.Nacionalidade.ToUpper();
            cbxNaturalidade.Text = aluno.Naturalidade.ToUpper();
            txbEndereco.Text = aluno.Endereco.ToUpper();
            cbxCidadeEndereco.Text = aluno.CidadeEndereco.ToUpper();
            txbCEP.Text = aluno.CEP;
            txbEmail.Text = aluno.Email.ToUpper();
            txbTelefone.Text = aluno.Telefone;
            txbContatoTelefone.Text = aluno.Contato;
            txbContatoNome.Text = aluno.ContatoNome.ToUpper();
            txbObs.Text = aluno.Obs.ToUpper();

            cbxCidadeEndereco.DataSource = mapeadorDeAluno.ObtemCidade();
            cbxCidadeEndereco.DisplayMember = "DESCRICAOCIDADE";
            cbxCidadeEndereco.Text = aluno.CidadeEndereco;

            cbxNaturalidade.DataSource = mapeadorDeAluno.ObtemCidade();
            cbxNaturalidade.DisplayMember = "DESCRICAOCIDADE";
            cbxNaturalidade.Text = aluno.Naturalidade;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbCEP.Clear();
            txbContatoNome.Clear();
            txbContatoTelefone.Clear();
            txbCPF.Clear();
            txbDataNascimento.Clear();
            txbEmail.Clear();
            txbEndereco.Clear();
            txbNacionalidade.Clear();
            txbNome.Clear();
            txbObs.Clear();
            txbTelefone.Clear();
            txbContatoNome.Clear();
            txbContatoTelefone.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //formHome home = new formHome();
            this.Close();
            home.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProcessoAluno processoAluno = new ProcessoAluno();
            
            var aluno = new Aluno()
            {
                Matricula = txbMatricula.Text,
                Nome = txbNome.Text.ToUpper(),
                CPF = txbCPF.Text,
                Sexo = cbxSexo.Text,
                Nascimento = txbDataNascimento.Text,
                Nacionalidade = txbNacionalidade.Text.ToUpper(),
                Naturalidade = cbxNaturalidade.Text.ToUpper(),
                Endereco = txbEndereco.Text.ToUpper(),
                CidadeEndereco = cbxCidadeEndereco.Text.ToUpper(),
                CEP = txbCEP.Text,
                Email = txbEmail.Text.ToUpper(),
                Telefone = txbTelefone.Text,
                Contato = txbContatoTelefone.Text,
                ContatoNome = txbContatoNome.Text.ToUpper(),
                Obs = txbObs.Text.ToUpper(),
            };
            if (processoAluno.EhValidoCampos(aluno))
            {
                processoAluno.AlteraAluno(aluno);
                //formHome home = new formHome();
                this.Close();
                home.Show();

            }
            
        }

        public void formEditar_Load(object sender, EventArgs e)
        {
           txbNome.Focus();
        }

        private void formEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.Show();
        }
    }
}
