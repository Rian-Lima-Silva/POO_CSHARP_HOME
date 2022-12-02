using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoCadastroMySQL
{
    public class MySQL
    {
        /// <summary>
        /// String de Conexão da classe Conexao
        /// </summary>
        public string conec = "SERVER=localhost; DATABASE=aula; UID=root; PWD=; PORT=;";

        /// <summary>
        /// Variavel que carrega conexão
        /// </summary>
        public MySqlConnection con = null;
        


        /// <summary>
        /// Metodo de Abertura de conexao com MySQL
        /// </summary>
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                if(ex.HResult == -2147467259)
                    MessageBox.Show("Incapaz de conectar com algum dos servidores MySQL","Conexao - AbrirConexao");
                else
                    MessageBox.Show("Número do Erro: "+ex.HResult+"\n\nErro no Servidor: "+ex.Message,"Servidor - Abrir Conexao");
            }
        }

        /// <summary>
        /// Metodo para fechar Conexao com MySQL
        /// </summary>
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no Servidor: " + ex.Message, "Servidor - Fechar Conexao");
            }
        }
    }
}
