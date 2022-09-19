using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Sistema_Escolar.Negocio;

namespace Sistema_Escolar.Mapeador
{
    public class Banco
    {
        Aluno aluno = new Aluno();
        public FbConnection conexao;
        private static readonly Banco instanciaFireBird = new Banco();
        

        public static Banco getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = @"DataSource=localhost; Database=C:\BancoSistemaEscolar\BANCOSISTEMAESCOLAR_2.5.fdb; username= SYSDBA; password = masterkey";
            return new FbConnection(conn);
        }
        
        public static DataTable consulta(string sql)
        {

            FbDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (FbConnection conexaoFireBird = getInstancia().getConexao())
                {
                    conexaoFireBird.Open();
                    da = new FbDataAdapter(sql, conexaoFireBird);
                    da.Fill(dt);
                    conexaoFireBird.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                throw (ex);
            }
        }
    }
}


