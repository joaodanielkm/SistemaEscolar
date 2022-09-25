using Sistema_Escolar.Mapeador;
using Sistema_Escolar.Negocio;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_Escolar.Processo
{
    public class ProcessoAluno
    {
        MapeadorDeAluno mapeador = new MapeadorDeAluno();

        public void CadastraAluno(Aluno aluno)
        {
            MapeadorDeAluno.InserirDadosAluno(aluno);
        }
        public void AlteraAluno(Aluno aluno)
        {
            MapeadorDeAluno.AlteraAluno(aluno);
        }
        public void DeletaAluno(string matricula)
        {
            MapeadorDeAluno mapeador = new MapeadorDeAluno();
            mapeador.ExcluiAluno(matricula);
        }
        public string ListaAluno(Aluno aluno)
        {
            var nomeAluno = aluno.Nome;
            return nomeAluno;
        }
        public bool EhValidoCampos(Aluno aluno) 
        {
            if (EhValidoObrigatorios(aluno))
            {
                return true;
            }
            else
            {
                ProcessoMsg msg = new ProcessoMsg();
                msg.FavorPreencherObrigatorios();
                return false;
            }
        }

        public bool EhValidoObrigatorios(Aluno aluno)
        => (!string.IsNullOrEmpty(aluno.Nome) && !string.IsNullOrEmpty(aluno.Matricula) && !string.IsNullOrEmpty(aluno.Nascimento) && !string.IsNullOrEmpty(aluno.Nacionalidade) && !string.IsNullOrEmpty(aluno.CEP) && !string.IsNullOrEmpty(aluno.Sexo) && !string.IsNullOrEmpty(aluno.Endereco));
         
        public void PreencheDataGridView()
        {
            formHome formHome = new formHome();
            //var dataGridView = new DataGridView();

            formHome.dtgListaDeAlunos.Columns.Clear();


            List<Aluno> aluno = new MapeadorDeAluno().ObtenhaAlunos();
            formHome.dtgListaDeAlunos.DataSource = aluno;

            formHome.dtgListaDeAlunos.AllowUserToAddRows = false;

            formHome.dtgListaDeAlunos.Columns[0].HeaderText = "Matricula";
            formHome.dtgListaDeAlunos.Columns[0].DataPropertyName = nameof(Aluno.Matricula);
            formHome.dtgListaDeAlunos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[1].HeaderText = "Nome";
            formHome.dtgListaDeAlunos.Columns[1].DataPropertyName = nameof(Aluno.Nome);
            formHome.dtgListaDeAlunos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[2].HeaderText = "CPF";
            formHome.dtgListaDeAlunos.Columns[2].DataPropertyName = nameof(Aluno.CPF);
            formHome.dtgListaDeAlunos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[3].HeaderText = "Sexo";
            formHome.dtgListaDeAlunos.Columns[3].DataPropertyName = nameof(Aluno.Sexo);
            formHome.dtgListaDeAlunos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[4].HeaderText = "Nascimento";
            formHome.dtgListaDeAlunos.Columns[4].DataPropertyName = nameof(Aluno.Nascimento);
            formHome.dtgListaDeAlunos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[5].HeaderText = "Nascionalidade";
            formHome.dtgListaDeAlunos.Columns[5].DataPropertyName = nameof(Aluno.Nacionalidade);
            formHome.dtgListaDeAlunos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[6].HeaderText = "Naturalidade";
            formHome.dtgListaDeAlunos.Columns[6].DataPropertyName = nameof(Aluno.Naturalidade);
            formHome.dtgListaDeAlunos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[7].HeaderText = "Endereco";
            formHome.dtgListaDeAlunos.Columns[7].DataPropertyName = nameof(Aluno.Endereco);
            formHome.dtgListaDeAlunos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[8].HeaderText = "Cidade Endereço";
            formHome.dtgListaDeAlunos.Columns[8].DataPropertyName = nameof(Aluno.CidadeEndereco);
            formHome.dtgListaDeAlunos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[9].HeaderText = "CEP";
            formHome.dtgListaDeAlunos.Columns[9].DataPropertyName = nameof(Aluno.CEP);
            formHome.dtgListaDeAlunos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[10].HeaderText = "Email";
            formHome.dtgListaDeAlunos.Columns[10].DataPropertyName = nameof(Aluno.Email);
            formHome.dtgListaDeAlunos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[11].HeaderText = "Telefone";
            formHome.dtgListaDeAlunos.Columns[11].DataPropertyName = nameof(Aluno.Telefone);
            formHome.dtgListaDeAlunos.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[12].HeaderText = "Fone Contato";
            formHome.dtgListaDeAlunos.Columns[12].DataPropertyName = nameof(Aluno.Contato);
            formHome.dtgListaDeAlunos.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[13].HeaderText = "Contato";
            formHome.dtgListaDeAlunos.Columns[13].DataPropertyName = nameof(Aluno.ContatoNome);
            formHome.dtgListaDeAlunos.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[14].HeaderText = "Obs";
            formHome.dtgListaDeAlunos.Columns[14].DataPropertyName = nameof(Aluno.Obs);
            formHome.dtgListaDeAlunos.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            formHome.dtgListaDeAlunos.Columns[0].Width = 78;
            formHome.dtgListaDeAlunos.Columns[1].Width = 350;
            formHome.dtgListaDeAlunos.Columns[2].Width = 100;
            formHome.dtgListaDeAlunos.Columns[3].Visible = false;
            formHome.dtgListaDeAlunos.Columns[4].Visible = false;
            formHome.dtgListaDeAlunos.Columns[5].Visible = false;
            formHome.dtgListaDeAlunos.Columns[6].Visible = false;
            formHome.dtgListaDeAlunos.Columns[7].Visible = false;
            formHome.dtgListaDeAlunos.Columns[8].Visible = false;
            formHome.dtgListaDeAlunos.Columns[9].Visible = false;
            formHome.dtgListaDeAlunos.Columns[10].Visible = false;
            formHome.dtgListaDeAlunos.Columns[11].Width = 100;
            formHome.dtgListaDeAlunos.Columns[12].Visible = false;
            formHome.dtgListaDeAlunos.Columns[13].Visible = false;
            formHome.dtgListaDeAlunos.Columns[14].Visible = false; ;
        } 
        }
    }
    

