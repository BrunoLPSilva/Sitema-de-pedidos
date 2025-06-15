using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_product_orders.domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }


        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void AtualizarDados(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Construtor vazio exigido pelo EF
        protected Produto() { }
    }
}
