using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqCSharp
{
    /**Linq Video 1
             * LinqFiltrar(listaProdutos);
             * LinqFiltrarClassificar(listaProdutos);
             * LinqAgrupar(listaProdutos);*/

    /** Linq Video 2
             * LinqSingle(indice,listaProdutos);
             * LinqSingleOrDefault(indice,listaProdutos);
             * LinqFirst(indice,listaProdutos);
             * LinqFirstOrDefault(indice, listaProdutos);
             * LinqLast(indice, listaProdutos);
             * LinqLastOrDefault(indice, listaProdutos);
             */

    /**Linq Video 3
             * LinqMax(listaProdutos)
             * LinqMin(listaProdutos)
             * LinqCount(listaProdutos)
             * LinqSum(listaProdutos)
             * LinqAverage(listaProdutos)
             */

    public partial class FrmLinq : Form
    {
        public FrmLinq()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int? indice = 0;
            //Pega os dados da 'tabela'
            var listaProdutos = new Produtos().GetAll();

            //Int para usar nos Linq Video 2
            if (txtFiltro.Text == "")
                indice = null;
            else
                indice = Convert.ToInt32(txtFiltro.Text);


           
        }

        /// <summary>
        /// Calculo de media 
        /// </summary>
        /// <param name="listaProdutos"></param>
        /// <returns></returns>
        private double LinqAverage(List<Produtos> listaProdutos)
        {
            double result = (from produto in listaProdutos
                             select produto.Quantidade).Average();

            return result;
        }

        /// <summary>
        /// Soma os valores da lista(ou banco de dados) usados
        /// </summary>
        /// <param name="listProdutos"></param>
        /// <returns></returns>
        private decimal LinqSum(List<Produtos> listProdutos)
        {
            var result = (from produto in listProdutos
                          select (produto.Quantidade * produto.Unitario)).Sum();

            return result;
        }

        /// <summary>
        /// Faz uma contagem da quantidade total de algo
        /// </summary>
        /// <param name="listaProdutos"></param>
        /// <returns> devolve um número inteiro</returns>
        private int LinqCount(List<Produtos> listaProdutos)
        {
            int result = (from produto in listaProdutos
                          where produto.Setor == "Alimentos"
                          select produto).Count();

            return result;
        }

        /// <summary>
        /// Pega o maior valor da lista
        /// </summary>
        /// <param name="listaProdutos"></param>
        /// <returns>variavel decimal</returns>
        private decimal LinqMax(List<Produtos> listaProdutos)
        {
            decimal result = (from produto in listaProdutos
                              select produto.Unitario).Max();

            return result;
        }

        /// <summary>
        /// Pega omenor valor da lista
        /// </summary>
        /// <param name="listaProdutos"></param>
        /// <returns>variavel decimal</returns>
        private decimal LinqMin(List<Produtos> listaProdutos)
        {
            // where produto.Setor == "Limpeza"
            decimal result = (from produto in listaProdutos
                              where produto.Setor == "Limpeza"
                              select produto.Unitario).Min();

            return result;
        }


        /// <summary>
        /// Filtro de dados, usando Linq
        /// </summary>
        /// <param name="listaProdutos"> fonte de dados que será instancianda com o clique do botão</param>
        private void LinqFiltrar(List<Produtos> listaProdutos)
        {
            var listaProdutosFiltrada =
            from produto in listaProdutos
            where produto.Id < 15
            select produto;

            foreach (var item in listaProdutosFiltrada)
            {
                MessageBox.Show(item.Descricao);
            }
        }

        /// <summary>
        /// Filtrar e Classificar com Linq
        /// </summary>
        /// <param name="listaProdutos"> fonte de dados em forma de List</param>
        private void LinqFiltrarClassificar(List<Produtos> listaProdutos)
        {
            var listaProdutosFiltradaClassificada =
            from produto in listaProdutos
            where produto.Id < 15
            orderby produto.Descricao ascending
            select produto;

            foreach (var item in listaProdutosFiltradaClassificada)
            {
                MessageBox.Show(item.Descricao);
            }
        }

        /// <summary>
        /// Cria um agrupamento de dados com base em seu setor
        /// </summary>
        /// <param name="listaProdutos"></param>
        private void LinqAgrupar(List<Produtos> listaProdutos)
        {
            var listaProdutoAgrupada =
            from produto in listaProdutos
            group produto by produto.Setor into setorGrupo
            orderby setorGrupo.Key ascending
            select setorGrupo;

            foreach (var grupo in listaProdutoAgrupada)
            {
                var nomeGrupo = "Grupo: " + grupo.Key;

                foreach (var produto in grupo)
                {
                    MessageBox.Show(nomeGrupo + ": " + produto.Id + " " + produto.Descricao);

                }
            }

        }

        /// <summary>
        /// Procurar itens com base no id passado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaProdutos"></param>
        /// <remarks>Single - retorna um elemento que satisfaça a condição ou gera uma exceção
        /// caso aja mais de uma elemento que satisfaça a condição </remarks>
        private void LinqSingle(int id, List<Produtos> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.Single(p => p.Id == id);
                //MessageBox.Show(produto.Id + " - " + produto.Descricao);
                label1.Text = produto.Id + " - " + produto.Descricao;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                    MessageBox.Show("Id não encontrado ou encontrado em mais de um produto");
                else
                    MessageBox.Show(ex.HResult + " - " + ex.Message);
            }
        }

        private void LinqSingleOrDefault(int id, List<Produtos> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.SingleOrDefault(p => p.Id >= id);

                if (produto != null)
                    MessageBox.Show(produto.Id + " - " + produto.Descricao);
                //label1.Text = produto.Id + " - " + produto.Descricao;
                else
                    MessageBox.Show("Produto não encontrado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Numero do Erro: " + ex.HResult + " \n " + ex.Message);
            }
        }

        /// <summary>
        /// Se achar dois ou mais itens vai pegar o primeiro, mas se não achar vai lançar uma exceção
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaProdutos"></param>
        private void LinqFirst(int id, List<Produtos> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.First(p => p.Id >= id);
                MessageBox.Show(produto.Id + " - " + produto.Descricao);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                    MessageBox.Show("Produto não encontrado");
                else
                    MessageBox.Show("Numero do Erro: " + ex.HResult + " \n " + ex.Message);
            }
        }

        /// <summary>
        /// Pegar o primeiro numero
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaProdutos"></param>
        /// <return>Valor encontrado ou default=null </return>
        /// <remarks>Caso, Condição possua multiplos resultados, deve se envolver um try_catch para lidar com as exceçôes</remarks>
        private void LinqFirstOrDefault(int id, List<Produtos> listaProdutos)
        {
            var produto = listaProdutos.FirstOrDefault(p => p.Id == id);
            

            if (produto != null)
                MessageBox.Show(produto.Id + " - " + produto.Descricao);
            else
                MessageBox.Show("Produto não encontrado");
        }

        /// <summary>
        /// Se achar dois ou mais itens vai pegar o ultimo, mas se não achar vai lançar uma exceção
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaProdutos"></param>
        private void LinqLast(int id, List<Produtos> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.Last(p => p.Id >= id);
                MessageBox.Show(produto.Id + " - " + produto.Descricao);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                    MessageBox.Show("Produto não encontrado");
                else
                    MessageBox.Show("Numero do Erro: " + ex.HResult + " \n " + ex.Message);
            }
        }

        /// <summary>
        /// Pegar o ultimo numero
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaProdutos"></param>
        /// <return>Valor encontrado ou default=null </return>
        /// <remarks>Caso, Condição possua multiplos resultados, deve se envolver um try_catch para lidar com as exceçôes</remarks>
        private void LinqLastOrDefault(int id, List<Produtos> listaProdutos)
        {
            var produto = listaProdutos.FirstOrDefault(p => p.Id >= id);


            if (produto != null)
                MessageBox.Show(produto.Id + " - " + produto.Descricao);
            else
                MessageBox.Show("Produto não encontrado");
        }
    }
}
