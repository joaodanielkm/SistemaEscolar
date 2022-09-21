using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Sistema_Escolar.Negocio;
using Sistema_Escolar.Processo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Sistema_Escolar.Mapeador
{
    public class MapeadorDeAluno
    {
        DataTable dt = new DataTable();
        DataAdapter da = null;
        Banco banco = new Banco();
        FbConnection conexaoFireBird = Banco.getInstancia().getConexao();
        ProcessoMsg msg = new ProcessoMsg();

        public static void InserirDadosAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = Banco.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = $"INSERT INTO ALUNOS" +
"(ALUMATRICULA, ALUNOME, ALUCPF, ALUENDERECO, ALUEMAIL, ALUSEXO, ALUNACIONAL, ALUNATURAL, ALUDATANASC, ALUTELEFONE)" +
"VALUES(@matricula, @nome, @CPF, @endereco, @Email, @Sexo, @nacionalidade, @naturalidade, @nascimento, @telefone)";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);


                    cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nacionalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@naturalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nascimento", SqlDbType.VarChar);
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

                    cmd.Parameters["@matricula"].Value = aluno.Matricula;
                    cmd.Parameters["@nome"].Value = aluno.Nome;
                    cmd.Parameters["@CPF"].Value = aluno.CPF;
                    cmd.Parameters["@endereco"].Value = aluno.Endereco;
                    cmd.Parameters["@Email"].Value = aluno.Email;
                    cmd.Parameters["@Sexo"].Value = aluno.Sexo;
                    cmd.Parameters["@nacionalidade"].Value = aluno.Nacionalidade;
                    cmd.Parameters["@naturalidade"].Value = aluno.Naturalidade;
                    cmd.Parameters["@nascimento"].Value = aluno.Nascimento;
                    cmd.Parameters["@telefone"].Value = aluno.Telefone;

                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public static void AlteraAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = Banco.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = $"UPDATE ALUNOS" +
"(ALUMATRICULA, ALUNOME, ALUCPF, ALUENDERECO, ALUEMAIL, ALUSEXO, ALUNACIONAL, ALUNATURAL, ALUDATANASC, ALUTELEFONE)" +
"VALUES(@matricula, @nome, @CPF, @endereco, @Email, @Sexo, @nacionalidade, @naturalidade, @nascimento, @telefone)";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);


                    cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nacionalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@naturalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nascimento", SqlDbType.VarChar);
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

                    cmd.Parameters["@matricula"].Value = aluno.Matricula;
                    cmd.Parameters["@nome"].Value = aluno.Nome;
                    cmd.Parameters["@CPF"].Value = aluno.CPF;
                    cmd.Parameters["@endereco"].Value = aluno.Endereco;
                    cmd.Parameters["@Email"].Value = aluno.Email;
                    cmd.Parameters["@Sexo"].Value = aluno.Sexo;
                    cmd.Parameters["@nacionalidade"].Value = aluno.Nacionalidade;
                    cmd.Parameters["@naturalidade"].Value = aluno.Naturalidade;
                    cmd.Parameters["@nascimento"].Value = aluno.Nascimento;
                    cmd.Parameters["@telefone"].Value = aluno.Telefone;

                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public List<Aluno> ObtenhaAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            string sql = @"SELECT * FROM ALUNOS A
INNER JOIN CIDADES C ON A.ALUNACIONAL = C.CODCIDADE ";

            DataTable dt = Banco.consulta(sql);

            foreach (DataRow item in dt.Rows)
            {
                Aluno aluno = new Aluno()
                {
                    //Matricula = item.Field<string>("A.ALUMATRICULA"),
                    Nome = item.Field<string>("ALUNOME"),
                    CPF = item.Field<string>("ALUCPF"),
                    Sexo = item.Field<string>("ALUSEXO"),
                    Nascimento = item.Field<string>("ALUDATANASC"),
                    Nacionalidade = item.Field<string>("DESCRICAOCIDADE"),
                    Naturalidade = item.Field<string>("DESCRICAOCIDADE"),
                    Endereco = item.Field<string>("ALUENDERECO"),
                    CEP = item.Field<string>("ALUCEP"),
                    Email = item.Field<string>("ALUEMAIL"),
                    Telefone = item.Field<string>("ALUTELEFONE"),
                    Contato = item.Field<string>("ALUFONECONTATO"),
                    ContatoNome = item.Field<string>("ALUCONTATO"),
                    Obs = item.Field<string>("ALUOBS"),
                };

                alunos.Add(aluno);
            }

            return alunos;
        }
        public void ExcluiAluno(string matricula)
        {
            try
            {
                var sql = $"DELETE FROM ALUNOS WHERE ALUNOME = '{matricula}'";
                Banco.consulta(sql);
                msg.Deletado();
            }
            catch (FbException fbex)
            {
                throw (fbex);
            }

        }
        //public DataTable ObtemAlunos() //=>
                //   Banco.consulta ("SELECT * FROM ALUNOS A INNER JOIN CIDADES C ON A.ALUNACIONAL = C.CODCIDADE WHERE A.ALUNOME LIKE 'JOAO DANIEL'");
        
        public DataTable ObtemCidade() =>
            dt = Banco.consulta("SELECT DESCRICAOCIDADE FROM CIDADES");
        
    }
}


