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

        //Aluno aluno = new Aluno();
        ProcessoAluno processoAluno = new ProcessoAluno();
         
        public formCadastro()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            processoAluno.CadastraAluno(aluno);

        }
    }
}
