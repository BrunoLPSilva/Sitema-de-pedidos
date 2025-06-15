using project_product_orders.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_product_orders.domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<int> AdicionarAsync(Produto produto);
        Task<IEnumerable<Produto>> ObterTodosAsync();

        Task AtualizarAsync(Produto produto);
        Task<Produto> ObterPorIdAsync(int id);
    }
}
