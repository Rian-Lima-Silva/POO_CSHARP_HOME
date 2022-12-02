using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqCSharp
{
    public class Produtos
    {   
        /// <summary>
        /// Campo Id da classe Produtos
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Campo Descricao da classe Produtos
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Campo Unitario da classe Produtos
        /// </summary>
        public decimal Unitario { get; set; }

        /// <summary>
        /// Campo Quantidade da classe Produtos
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Campo Setor da classe Produtos
        /// </summary>
        public string Setor { get; set; }



        /// <summary>
        /// Contrutor Vazio
        /// </summary>
        public Produtos() { }



        /// <summary>
        /// Construtor que recebe os dados por paramentro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <param name="unitario"></param>
        /// <param name="setor"></param>
        public Produtos( int id, string descricao,decimal unitario, int quatidade,string setor)
        {
            Id = id;
            Descricao = descricao;
            Unitario = unitario;
            Quantidade = quatidade;
            Setor = setor;
        }

        /// <summary>
        /// Esse metodo ira devolver uma lista de produtos
        /// </summary>
        /// <returns>uma lista de dados</returns>
        public List<Produtos> GetAll()
        {
             var listaProdutos = new List<Produtos>();

             listaProdutos.Add(new Produtos(2,"Café em pó 250 gramas",10.83M,20,"Alimentos"));
             listaProdutos.Add(new Produtos(4,"Sabão em pó 500 gramas",16.50M,35,"Limpeza"));
             listaProdutos.Add(new Produtos(7,"Óleo de Soja 1 litro",7.23M,43,"Alimentos"));
             listaProdutos.Add(new Produtos(13,"Café em pó 500 gramas",19.99M,34,"Alimentos"));
             listaProdutos.Add(new Produtos(18, "Óleo de girassol 1 litro", 9.96M,45,"Alimentos"));
             listaProdutos.Add(new Produtos(21,"Sabão em pedra 250 gramas",4.12M,65,"Limpeza"));
             listaProdutos.Add(new Produtos(27,"Suco de uva 350 ml",3.89M,12,"Alimentos"));

             return listaProdutos;
        }



    }
}
