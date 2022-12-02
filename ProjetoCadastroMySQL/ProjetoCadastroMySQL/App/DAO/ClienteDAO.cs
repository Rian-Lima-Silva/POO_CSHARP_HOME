using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProjetoCadastroMySQL
{
    /// <summary>
    /// Consulta com MySQL Tabela Cliente
    /// </summary>
    public class ClienteDAO:MySQL
    {
        string sql;
        MySqlCommand cmd;

        /// <summary>
        /// Objeto Construtor de CRUD cliente
        /// </summary>
        /// <remarks>Create (INSERT)</remarks>
        /// <remarks>Read (SELECT)</remarks>
        /// <remarks>Update (UPDATE)</remarks>
        /// <remarks>Create (DELETE)</remarks>
        public ClienteDAO() { }

        /// <summary>
        /// Metodo que pesquisa por um dado especifico com base no nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable SearchByName(string nome)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                sql = "SELECT * FROM cliente WHERE nome LIKE @nome ORDER BY nome ASC";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome","%"+nome+"%");

                da.SelectCommand = cmd;
                da.Fill(dt);
                //return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no SearchByName: " + ex.Message, "DAO - Carragar Tabela");
            }
            finally
            {
                FecharConexao();
            }

            return dt;

        }

        /// <summary>
        /// Metodo de Busca os TODOS os dados da tabela
        /// </summary>
        public DataTable GetAllRows()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            { 
                AbrirConexao();
                sql = "SELECT * FROM cliente ORDER BY id DESC";
                cmd = new MySqlCommand(sql, con);

                da.SelectCommand = cmd;
                da.Fill(dt);
                //return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no GetAllRows: " + ex.Message, "DAO - Carragar Tabela");
            }
            finally
            {
                FecharConexao();
            }

            return dt;

        }


        /// <summary>
        /// Metodo de inserção de dados na Tabela cliente
        /// </summary>
        /// <remarks>Create (INSERT)</remarks>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        public void Insert(string nome, string endereco, string cpf, string telefone, byte[] imagem)
        {
            try
            {

                AbrirConexao();

                sql = "INSERT INTO cliente(nome,endereco,cpf,telefone,imagem) VALUES (@nome,@endereco,@cpf,@telefone,@imagem)";
                cmd = new MySqlCommand(sql,con);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@imagem", imagem);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no Update: " + ex.Message, "Consulta com o Banco de Dados");
            }
            finally
            {
                FecharConexao();
            }
        }

        /// <summary>
        /// Metodo de atualização de dados na Tabela cliente
        /// </summary>
        /// <remarks>Update (UPDATE)</remarks>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="id"></param>
        /// <param name="imagem"></param>
        public void Update(int id,string nome, string endereco, string cpf, string telefone,byte[] imagem)
        {
            try
            {
                AbrirConexao();
                sql = "UPDATE cliente SET nome=@nome, endereco=@endereco, cpf=@cpf, telefone=@telefone, imagem=@imagem WHERE id=@id";
                cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@imagem", imagem);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no Update: " + ex.Message, "Consulta com o Banco de Dados");
            }
            finally
            {
                FecharConexao();
            }
        }       
        
        /// <summary>
        /// Metodo de atualização de dados na Tabela cliente
        /// </summary>
        /// <remarks>Update (UPDATE)</remarks>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="id"></param>
        public void Update(int id,string nome, string endereco, string cpf, string telefone)
        {
            try
            {
                AbrirConexao();
                sql = "UPDATE cliente SET nome=@nome, endereco=@endereco, cpf=@cpf, telefone=@telefone WHERE id=@id";
                cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no Update: " + ex.Message, "Consulta com o Banco de Dados");
            }
            finally
            {
                FecharConexao();
            }
        }

        /// <summary>
        /// Metodo de exlusão de dados na Tabela cliente
        /// </summary>
        /// <remarks>Delete (Delete)</remarks>
        /// <param name="id"></param>
        public void Delete(int id)
        {

            try
            {
                AbrirConexao();
                sql = "DELETE FROM cliente WHERE id=@id";
                cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número do Erro: " + ex.HResult + "\n\nErro no Delete: " + ex.Message, "Consulta com o Banco de Dados");
            }
            finally
            {
                FecharConexao();
            }

        }
    }
}
