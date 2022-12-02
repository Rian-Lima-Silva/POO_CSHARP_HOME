using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProjetoSQLServerConnection
{
    public class SQLServerConexao
    {
        private static string server = @"(localdb)\MSSQLLocalDB";
        private static string dataBase = "AgenciaAuto";
        private static string user = "limac";
        private static string password = ""; 



        /// <summary>
        /// String de Conexao
        /// </summary>
        private static string StrCon
        {
            /**get { return "Data Source="+server+"Integrated Security=True; Initial Catalog="+dataBase+"; "+"User ID=" + user + "; Password=" + password; }
             */
            get
            {
                return $"Data Source={server}; Integrated Security=true; Initial Catalog={dataBase};User ID= {user}; Password={password}";
            }
        }

        public SqlConnection conexao=null;

        /// <summary>
        /// Metodo de Abertura de Conexao com SQLServer
        /// </summary>
        protected bool AbrirConexao()
        {
            try
            {
                conexao = new SqlConnection(StrCon);
                conexao.Open();
                //MessageBox.Show("Conexao bem sucedida","SQLServer",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                if(ex.HResult == -2146232060)
                {
                    MessageBox.Show("Os dados do servidor são invalidos", "SQLServer - AbrirConexao",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    MessageBox.Show("Número do Erro: "+ex.HResult+"\n\n Erro: "+ex.Message,"SQLServer - AbrirConexao",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
            }
        }

        /// <summary>
        /// Metodo de Fechamento de Conexao com SQLServer
        /// </summary>
       protected bool FecharConexao()
        {
            try
            {
                conexao = new SqlConnection(StrCon);
                conexao.Close();
                //MessageBox.Show("Conexao Fechada", "SQLServer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: "+ex.HResult+"\n\n Erro: "+ex.Message,"SQLServer - FecharConexao",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }



    }//
}//
