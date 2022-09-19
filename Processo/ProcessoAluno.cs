using Sistema_Escolar.Mapeador;
using Sistema_Escolar.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escolar.Processo
{
    public class ProcessoAluno
    {
        //Aluno aluno = new Aluno();
        MapeadorDeAluno mapeador = new MapeadorDeAluno();

        public void CadastraAluno(Aluno aluno)
        {
            MapeadorDeAluno.InserirDadosAluno(aluno);
        }
        public void AlteraAluno(Aluno aluno)
        {
            //MapeadorDeAluno.AlteraAluno(aluno);
        }
        public void DeletaAluno(string matricula)
        {
            MapeadorDeAluno mapeador = new MapeadorDeAluno();
            mapeador.ExcluiAluno(matricula);
        }
    }
    
}
