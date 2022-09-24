using Sistema_Escolar.Mapeador;
using Sistema_Escolar.Negocio;

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
    }
    
}
