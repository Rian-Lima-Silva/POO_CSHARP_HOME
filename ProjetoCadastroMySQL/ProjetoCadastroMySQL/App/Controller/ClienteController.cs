using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroMySQL
{ 
    public class ClienteController
    {

        /// <summary>
        /// Mostra dados ESPECIFICO com base no Nome na tabela cliente
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static DataTable Buscar(string nome)
        {    
            var clienteDao = new ClienteDAO();
            var table = clienteDao.SearchByName(nome);
            return table;
        }

        /// <summary>
        /// Mostra TODOS os dados da tabela cliente
        /// </summary>
        /// <returns></returns>
        public static DataTable Ver()
        {
            var clienteDao = new ClienteDAO();
            var table = clienteDao.GetAllRows();

            return table;
        }

        /// <summary>
        /// Adiciona ou Atualiza dados da Tabela Clientes
        /// </summary>
        /// <param name="nome">Campo Nome da tabela cliente</param>
        /// <param name="endereco">Campo Endereco da tabela cliente</param>
        /// <param name="cpf">Campo CPF da tabela cliente</param>
        /// <param name="telefone">Campo Telefoneda tabela cliente</param>
        /// <param name="imagem">Campo Imagem da tabela cliente</param>
        /// <returns> true para insert ou update</returns>
        public static bool Salvar(string nome, string endereco, string cpf, string telefone, byte[] imagem)
        {
            var clienteDao = new ClienteDAO();

            clienteDao.Insert(nome, endereco,cpf, telefone,imagem);
            MessageBox.Show("Cliente Cadastrado com sucesso!","Cadastro de Cliente",MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;   
            
            
        }

        public static bool Editar(int id,string nome, string endereco, string cpf, string telefone,byte[] imagem,bool alterar=false)
        {
            var clienteDao = new ClienteDAO();

            if (id > 0)
            {
                if (alterar == true)
                {
                    clienteDao.Update(id, nome, endereco, cpf, telefone, imagem);
                }
                else if(alterar == false)
                {
                    clienteDao.Update(id, nome, endereco, cpf, telefone);
                }
                MessageBox.Show("Registro de Cliente atualizadado com sucesso!", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (id == 0)
            {
                MessageBox.Show("Não foi possivel atualizar esse registro", "Cadastro de Cliente",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return false;
        }

        /// <summary>
        /// Excluir dados da Tabela Cliente
        /// </summary>
        /// <param name="id"></param>
        public static bool Excluir(int id)
        {
            if(id > 0)
            {
                var clienteDao = new ClienteDAO();

                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir esse registro?","Excluir",
                                                       MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    clienteDao.Delete(id);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }


    }//Classe

}//NameSpace
