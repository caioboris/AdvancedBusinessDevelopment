using Ecommerce.Produtos.Domain.Dtos;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Application.Services;

public class ProdutoApplicationService : IProdutoApplicationService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoApplicationService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public ProdutoDTO AdicionarProduto(ProdutoDTO categoria)
    {
        throw new NotImplementedException();
    }

    public ProdutoDTO EditarProduto(ProdutoDTO categoria)
    {
        throw new NotImplementedException();
    }

    public ProdutoDTO ExcluirProduto(ProdutoDTO categoria)
    {
        throw new NotImplementedException();
    }

    public ProdutoDTO ObterProdutoPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProdutoDTO> ObterTodosProdutos()
    {
        throw new NotImplementedException();
    }
}
