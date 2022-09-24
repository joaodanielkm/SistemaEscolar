using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;
using Sistema_Escolar.Negocio;
using Sistema_Escolar.Processo;

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
                    string mSQL =
"INSERT INTO ALUNOS (ALUMATRICULA, ALUNOME, ALUCPF, ALUENDERECO, ALUEMAIL, ALUSEXO, ALUNACIONAL, ALUNATURAL, ALUDATANASC, ALUTELEFONE, ALUCEP, ALUFONECONTATO, ALUCONTATO, ALUOBS, ALUENDCIDADE) VALUES (@matricula, @nome, @CPF, @endereco, @Email, @Sexo, @nacionalidade,(SELECT CODCIDADE  FROM CIDADES WHERE DESCRICAOCIDADE = @naturalidade), @nascimento, @telefone, @CEP, @foneContato, @nomeContato, @OBS,(SELECT CODCIDADE  FROM CIDADES WHERE DESCRICAOCIDADE = @cidadeEndereco))";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);


                    cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nascimento", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nacionalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@naturalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@cidadeEndereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                    cmd.Parameters.Add("@foneContato", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nomeContato", SqlDbType.VarChar);
                    cmd.Parameters.Add("@OBS", SqlDbType.VarChar);


                    cmd.Parameters["@matricula"].Value = aluno.Matricula;
                    cmd.Parameters["@nome"].Value = aluno.Nome;
                    cmd.Parameters["@CPF"].Value = aluno.CPF;
                    cmd.Parameters["@Sexo"].Value = aluno.Sexo;
                    cmd.Parameters["@nascimento"].Value = aluno.Nascimento;
                    cmd.Parameters["@nacionalidade"].Value = aluno.Nacionalidade;
                    cmd.Parameters["@naturalidade"].Value = aluno.Naturalidade;
                    cmd.Parameters["@endereco"].Value = aluno.Endereco;
                    cmd.Parameters["@cidadeEndereco"].Value = aluno.CidadeEndereco;
                    cmd.Parameters["@CEP"].Value = aluno.CEP;
                    cmd.Parameters["@Email"].Value = aluno.Email;
                    cmd.Parameters["@telefone"].Value = aluno.Telefone;
                    cmd.Parameters["@foneContato"].Value = aluno.Contato;
                    cmd.Parameters["@nomeContato"].Value = aluno.ContatoNome;
                    cmd.Parameters["@OBS"].Value = aluno.Obs;

                    cmd.ExecuteNonQuery();
                    ProcessoMsg msg = new ProcessoMsg();
                    msg.Cadastrado();
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
                    string mSQL = "UPDATE ALUNOS SET ALUNOME =  @nome, ALUCPF = @CPF, ALUSEXO = @Sexo, ALUDATANASC = @nascimento, ALUNACIONAL = @nacionalidade, ALUNATURAL = (SELECT CODCIDADE  FROM CIDADES WHERE DESCRICAOCIDADE = @naturalidade), ALUENDERECO = @endereco, ALUENDCIDADE = (SELECT CODCIDADE  FROM CIDADES WHERE DESCRICAOCIDADE = @cidadeEndereco), ALUCEP = @CEP, ALUEMAIL = @Email, ALUTELEFONE = @telefone, ALUFONECONTATO = @foneContato ,ALUCONTATO = @nomeContato ,ALUOBS = @OBS WHERE ALUMATRICULA = @matricula ";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);

                    cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nascimento", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nacionalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@naturalidade", SqlDbType.VarChar);
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@cidadeEndereco", SqlDbType.VarChar);
                    cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                    cmd.Parameters.Add("@foneContato", SqlDbType.VarChar);
                    cmd.Parameters.Add("@nomeContato", SqlDbType.VarChar);
                    cmd.Parameters.Add("@OBS", SqlDbType.VarChar);

                    cmd.Parameters["@matricula"].Value = aluno.Matricula;
                    cmd.Parameters["@nome"].Value = aluno.Nome;
                    cmd.Parameters["@CPF"].Value = aluno.CPF;
                    cmd.Parameters["@Sexo"].Value = aluno.Sexo;
                    cmd.Parameters["@nascimento"].Value = aluno.Nascimento;
                    cmd.Parameters["@nacionalidade"].Value = aluno.Nacionalidade;
                    cmd.Parameters["@naturalidade"].Value = aluno.Naturalidade;
                    cmd.Parameters["@endereco"].Value = aluno.Endereco;
                    cmd.Parameters["@cidadeEndereco"].Value = aluno.CidadeEndereco;
                    cmd.Parameters["@CEP"].Value = aluno.CEP;
                    cmd.Parameters["@Email"].Value = aluno.Email;
                    cmd.Parameters["@telefone"].Value = aluno.Telefone;
                    cmd.Parameters["@foneContato"].Value = aluno.Contato;
                    cmd.Parameters["@nomeContato"].Value = aluno.ContatoNome;
                    cmd.Parameters["@OBS"].Value = aluno.Obs;
                    

                    cmd.ExecuteNonQuery();
                    ProcessoMsg msg = new ProcessoMsg();
                    msg.Alterado();
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

            string sql = @"SELECT A.ALUMATRICULA AS ALUMATRICULA ,A.ALUNOME AS ALUNOME ,	A.ALUCPF AS ALUCPF ,A.ALUENDERECO AS ALUENDERECO ,A.ALUEMAIL AS ALUEMAIL ,
A.ALUSEXO AS ALUSEXO ,A.ALUNACIONAL AS ALUNACIONAL ,A.ALUNATURAL AS ALUNATURAL ,A.ALUDATANASC AS ALUDATANASC ,A.ALUTELEFONE AS ALUTELEFONE ,
A.ALUCEP AS ALUCEP ,A.ALUFONECONTATO AS ALUFONECONTATO ,A.ALUCONTATO AS ALUCONTATO ,A.ALUOBS AS ALUOBS ,A.ALUENDCIDADE AS ALUENDCIDADE,
C.DESCRICAOCIDADE AS CIDADENATU,CC.DESCRICAOCIDADE AS CIDADEEND
FROM ALUNOS A
INNER JOIN CIDADES C ON A.ALUNATURAL  = C.CODCIDADE
INNER JOIN CIDADES CC ON  A.ALUENDCIDADE = CC.CODCIDADE  ";

            DataTable dt = Banco.consulta(sql);

            foreach (DataRow item in dt.Rows)
            {
                Aluno aluno = new Aluno()
                {
                    Matricula = item.Field<string>("ALUMATRICULA"),
                    Nome = item.Field<string>("ALUNOME"),
                    CPF = item.Field<string>("ALUCPF"),
                    Sexo = item.Field<string>("ALUSEXO"),
                    Nascimento = item.Field<string>("ALUDATANASC"),
                    Nacionalidade = item.Field<string>("ALUNACIONAL"),
                    Naturalidade = item.Field<string>("CIDADENATU"),
                    Endereco = item.Field<string>("ALUENDERECO"),
                    CidadeEndereco = item.Field<string>("CIDADEEND"),
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
                var sql = $"DELETE FROM ALUNOS WHERE ALUMATRICULA = '{matricula}'";
                Banco.consulta(sql);
                msg.Deletado();
            }
            catch (FbException fbex)
            {
                throw (fbex);
            }

        }
        //public DataTable ObtemAlunos() =>
        //       Banco.consulta("SELECT * FROM ALUNOS A INNER JOIN CIDADES C ON A.ALUNACIONAL = C.CODCIDADE WHERE A.ALUNOME LIKE 'JOAO DANIEL'");

        public DataTable ObtemCidade() =>
            dt = Banco.consulta("SELECT CODCIDADE, DESCRICAOCIDADE FROM CIDADES");

        public DataTable ObtemUltimaMatricula() =>
            dt = Banco.consulta("SELECT max(CAST (ALUMATRICULA AS integer))+1 FROM ALUNOS");
    }
}


