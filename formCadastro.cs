using Sistema_Escolar.Mapeador;
using Sistema_Escolar.Negocio;
using Sistema_Escolar.Processo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class formCadastro : Form
    {

        ProcessoAluno processoAluno = new ProcessoAluno();
        MapeadorDeAluno mapeadorDeAluno = new MapeadorDeAluno();

        public formCadastro()
        {
            InitializeComponent();
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
            txbMatricula.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formHome home = new formHome();
            this.Close();
            home.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno()
            {
                Matricula = txbMatricula.Text,
                Nome = txbNome.Text.ToUpper(),
                CPF = txbCPF.Text,
                Sexo = cbxSexo.Text,
                Nascimento = txbDataNascimento.Text,
                Nacionalidade = cbxCidadeEndereco.Text.ToUpper(),
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
                processoAluno.CadastraAluno(aluno);
            }
            

        }

        public void formCadastro_Load(object sender, EventArgs e)
        {
            var dt = mapeadorDeAluno.ObtemUltimaMatricula();
            txbMatricula.Text = Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString();
            txbNacionalidade.Text = "BRASILEIRA";

            cbxCidadeEndereco.Items.Clear();
            cbxCidadeEndereco.DataSource = mapeadorDeAluno.ObtemCidade();
            cbxCidadeEndereco.DisplayMember = "DESCRICAOCIDADE";
            
            cbxNaturalidade.Items.Clear();
            cbxNaturalidade.DataSource = mapeadorDeAluno.ObtemCidade();
            cbxNaturalidade.DisplayMember = "DESCRICAOCIDADE";
            
            Aluno aluno = new Aluno();
            txbNome.Text = aluno.Nome;
        }
    }
}
