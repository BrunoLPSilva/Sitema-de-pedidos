using project_product_orders.application.DTOs;
using project_product_orders.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_product_orders.application.Interfaces
{
    public interface IProdutoService
    {
        Task<int> CriarProdutoAsync(ProdutoDTO dto);
        Task<IEnumerable<ProdutoDTO>> ListarProdutosAsync();

        Task AtualizarProdutoAsync(ProdutoUpdateDTO produtoDto);

    }
}
