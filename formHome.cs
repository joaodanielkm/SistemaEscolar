using FirebirdSql.Data.FirebirdClient;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Sistema_Escolar
{
    public partial class formHome : Form
    {
        formCadastro cadastro = new formCadastro();
        List<Aluno> aluno = new MapeadorDeAluno().ObtenhaAlunos();
        Banco banco = new Banco();
        ProcessoAluno processoAluno = new ProcessoAluno();
        ProcessoMsg msg = new ProcessoMsg();

        public formHome()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {

            dtgListaDeAlunos.DataSource = aluno;

            dtgListaDeAlunos.Columns[0].HeaderText = "Matricula";
            dtgListaDeAlunos.Columns[0].DataPropertyName = nameof(Aluno.Matricula);
            dtgListaDeAlunos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[1].HeaderText = "Nome";
            dtgListaDeAlunos.Columns[1].DataPropertyName = nameof(Aluno.Nome);
            dtgListaDeAlunos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[2].HeaderText = "CPF";
            dtgListaDeAlunos.Columns[2].DataPropertyName = nameof(Aluno.CPF);
            dtgListaDeAlunos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[3].HeaderText = "Sexo";
            dtgListaDeAlunos.Columns[3].DataPropertyName = nameof(Aluno.Sexo);
            dtgListaDeAlunos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[4].HeaderText = "Nascimento";
            dtgListaDeAlunos.Columns[4].DataPropertyName = nameof(Aluno.Nascimento);
            dtgListaDeAlunos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[5].HeaderText = "Nascionalidade";
            dtgListaDeAlunos.Columns[5].DataPropertyName = nameof(Aluno.Nacionalidade);
            dtgListaDeAlunos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[6].HeaderText = "Naturalidade";
            dtgListaDeAlunos.Columns[6].DataPropertyName = nameof(Aluno.Naturalidade);
            dtgListaDeAlunos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[7].HeaderText = "Endereco";
            dtgListaDeAlunos.Columns[7].DataPropertyName = nameof(Aluno.Endereco);
            dtgListaDeAlunos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[8].HeaderText = "Cidade Endereço";
            dtgListaDeAlunos.Columns[8].DataPropertyName = nameof(Aluno.CidadeEndereco);
            dtgListaDeAlunos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[9].HeaderText = "CEP";
            dtgListaDeAlunos.Columns[9].DataPropertyName = nameof(Aluno.CEP);
            dtgListaDeAlunos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[10].HeaderText = "Email";
            dtgListaDeAlunos.Columns[10].DataPropertyName = nameof(Aluno.Email);
            dtgListaDeAlunos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[11].HeaderText = "Telefone";
            dtgListaDeAlunos.Columns[11].DataPropertyName = nameof(Aluno.Telefone);
            dtgListaDeAlunos.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[12].HeaderText = "Fone Contato";
            dtgListaDeAlunos.Columns[12].DataPropertyName = nameof(Aluno.Contato);
            dtgListaDeAlunos.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[13].HeaderText = "Contato";
            dtgListaDeAlunos.Columns[13].DataPropertyName = nameof(Aluno.ContatoNome);
            dtgListaDeAlunos.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[14].HeaderText = "Obs";
            dtgListaDeAlunos.Columns[14].DataPropertyName = nameof(Aluno.Obs);
            dtgListaDeAlunos.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgListaDeAlunos.Columns[0].Width = 80;
            dtgListaDeAlunos.Columns[1].Width = 50;
            dtgListaDeAlunos.Columns[2].Width = 50;
            dtgListaDeAlunos.Columns[3].Width = 50;
            dtgListaDeAlunos.Columns[4].Width = 50;
            dtgListaDeAlunos.Columns[5].Width = 50;
            dtgListaDeAlunos.Columns[6].Width = 50;
            dtgListaDeAlunos.Columns[7].Width = 50;
            dtgListaDeAlunos.Columns[8].Width = 50;
            dtgListaDeAlunos.Columns[9].Width = 50;
            dtgListaDeAlunos.Columns[10].Width = 50;
            dtgListaDeAlunos.Columns[11].Width = 50;
            dtgListaDeAlunos.Columns[12].Width = 50;
            dtgListaDeAlunos.Columns[13].Width = 50;
            dtgListaDeAlunos.Columns[14].Width = 50;


        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            formCadastro cadastro = new formCadastro();
            cadastro.ShowDialog();
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            int sel = dtgListaDeAlunos.CurrentRow.Index;
            var aluno = new Aluno()
            {
                Matricula = Convert.ToString(dtgListaDeAlunos["Matricula", sel].Value),
                Nome = Convert.ToString(dtgListaDeAlunos["Nome", sel].Value),
                CPF = Convert.ToString(dtgListaDeAlunos["CPF", sel].Value),
                Sexo = Convert.ToString(dtgListaDeAlunos["Sexo", sel].Value),
                Nascimento = Convert.ToString(dtgListaDeAlunos["Nascimento", sel].Value),
                Nacionalidade = Convert.ToString(dtgListaDeAlunos["Nacionalidade", sel].Value),
                Naturalidade = Convert.ToString(dtgListaDeAlunos["Naturalidade", sel].Value),
                Endereco = Convert.ToString(dtgListaDeAlunos["Endereco", sel].Value),
                CidadeEndereco = Convert.ToString(dtgListaDeAlunos["CidadeEndereco", sel].Value),
                CEP = Convert.ToString(dtgListaDeAlunos["CEP", sel].Value),
                Email = Convert.ToString(dtgListaDeAlunos["Email", sel].Value),
                Telefone = Convert.ToString(dtgListaDeAlunos["Telefone", sel].Value),
                Contato = Convert.ToString(dtgListaDeAlunos["Contato", sel].Value),
                ContatoNome = Convert.ToString(dtgListaDeAlunos["ContatoNome", sel].Value),
                Obs = Convert.ToString(dtgListaDeAlunos["Obs", sel].Value),
            };

            formEditar telaEditar = new formEditar(aluno);
            telaEditar.Show();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var mensg = msg.DesejaDeletar();

            if (mensg == DialogResult.Yes)
            {
                int sel = dtgListaDeAlunos.CurrentRow.Index;
                processoAluno.DeletaAluno(Convert.ToString(dtgListaDeAlunos["Matricula", sel].Value));


                
                //dtgListaDeAlunos.Update();
                dtgListaDeAlunos.Columns.Clear();


                List<Aluno> aluno = new MapeadorDeAluno().ObtenhaAlunos();
                dtgListaDeAlunos.DataSource = aluno;

                dtgListaDeAlunos.Columns[0].HeaderText = "Matricula";
                dtgListaDeAlunos.Columns[0].DataPropertyName = nameof(Aluno.Matricula);
                dtgListaDeAlunos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[1].HeaderText = "Nome";
                dtgListaDeAlunos.Columns[1].DataPropertyName = nameof(Aluno.Nome);
                dtgListaDeAlunos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[2].HeaderText = "CPF";
                dtgListaDeAlunos.Columns[2].DataPropertyName = nameof(Aluno.CPF);
                dtgListaDeAlunos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[3].HeaderText = "Sexo";
                dtgListaDeAlunos.Columns[3].DataPropertyName = nameof(Aluno.Sexo);
                dtgListaDeAlunos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[4].HeaderText = "Nascimento";
                dtgListaDeAlunos.Columns[4].DataPropertyName = nameof(Aluno.Nascimento);
                dtgListaDeAlunos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[5].HeaderText = "Nascionalidade";
                dtgListaDeAlunos.Columns[5].DataPropertyName = nameof(Aluno.Nacionalidade);
                dtgListaDeAlunos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[6].HeaderText = "Naturalidade";
                dtgListaDeAlunos.Columns[6].DataPropertyName = nameof(Aluno.Naturalidade);
                dtgListaDeAlunos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[7].HeaderText = "Endereco";
                dtgListaDeAlunos.Columns[7].DataPropertyName = nameof(Aluno.Endereco);
                dtgListaDeAlunos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[8].HeaderText = "Cidade Endereço";
                dtgListaDeAlunos.Columns[8].DataPropertyName = nameof(Aluno.CidadeEndereco);
                dtgListaDeAlunos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[9].HeaderText = "CEP";
                dtgListaDeAlunos.Columns[9].DataPropertyName = nameof(Aluno.CEP);
                dtgListaDeAlunos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[10].HeaderText = "Email";
                dtgListaDeAlunos.Columns[10].DataPropertyName = nameof(Aluno.Email);
                dtgListaDeAlunos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[11].HeaderText = "Telefone";
                dtgListaDeAlunos.Columns[11].DataPropertyName = nameof(Aluno.Telefone);
                dtgListaDeAlunos.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[12].HeaderText = "Fone Contato";
                dtgListaDeAlunos.Columns[12].DataPropertyName = nameof(Aluno.Contato);
                dtgListaDeAlunos.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[13].HeaderText = "Contato";
                dtgListaDeAlunos.Columns[13].DataPropertyName = nameof(Aluno.ContatoNome);
                dtgListaDeAlunos.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[14].HeaderText = "Obs";
                dtgListaDeAlunos.Columns[14].DataPropertyName = nameof(Aluno.Obs);
                dtgListaDeAlunos.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dtgListaDeAlunos.Columns[0].Width = 80;
                dtgListaDeAlunos.Columns[1].Width = 50;
                dtgListaDeAlunos.Columns[2].Width = 50;
                dtgListaDeAlunos.Columns[3].Width = 50;
                dtgListaDeAlunos.Columns[4].Width = 50;
                dtgListaDeAlunos.Columns[5].Width = 50;
                dtgListaDeAlunos.Columns[6].Width = 50;
                dtgListaDeAlunos.Columns[7].Width = 50;
                dtgListaDeAlunos.Columns[8].Width = 50;
                dtgListaDeAlunos.Columns[9].Width = 50;
                dtgListaDeAlunos.Columns[10].Width = 50;
                dtgListaDeAlunos.Columns[11].Width = 50;
                dtgListaDeAlunos.Columns[12].Width = 50;
                dtgListaDeAlunos.Columns[13].Width = 50;
                dtgListaDeAlunos.Columns[14].Width = 50;


            }


        }
    }
}
