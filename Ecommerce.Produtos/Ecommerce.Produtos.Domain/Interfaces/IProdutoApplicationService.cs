using Ecommerce.Produtos.Domain.Dtos;

namespace Ecommerce.Produtos.Domain.Interfaces;

public interface IProdutoApplicationService
{
    ProdutoDTO ObterProdutoPorId(int id);
    IEnumerable<ProdutoDTO> ObterTodosProdutos();
    ProdutoDTO AdicionarProduto(ProdutoDTO categoria);
    ProdutoDTO EditarProduto(ProdutoDTO categoria);
    ProdutoDTO ExcluirProduto(ProdutoDTO categoria);
}
