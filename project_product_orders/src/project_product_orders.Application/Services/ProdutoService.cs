using project_product_orders.application.DTOs;
using project_product_orders.Application.DTOs;
using project_product_orders.application.Interfaces;
using project_product_orders.domain.Entities;
using project_product_orders.domain.Interfaces;

namespace project_product_orders.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<int> CriarProdutoAsync(ProdutoDTO dto)
        {
            var produto = new Produto(dto.Nome, dto.Preco); // Supondo que exista esse construtor
            return await _produtoRepository.AdicionarAsync(produto);
        }

        public async Task<IEnumerable<ProdutoDTO>> ListarProdutosAsync()
        {
            var produtos = await _produtoRepository.ObterTodosAsync();
            return produtos.Select(p => new ProdutoDTO
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco
            });
        }

        public async Task AtualizarProdutoAsync(ProdutoUpdateDTO dto)
        {
            var produto = await _produtoRepository.ObterPorIdAsync(dto.Id);
            if (produto == null)
                throw new Exception("Produto não encontrado");

            produto.AtualizarDados(dto.Nome, dto.Preco);

            await _produtoRepository.AtualizarAsync(produto);
        }

    }
}
