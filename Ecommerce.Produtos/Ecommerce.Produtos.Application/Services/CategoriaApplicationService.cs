using Ecommerce.Produtos.Domain.Dtos;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Application.Services;

public class CategoriaApplicationService : ICategoriaApplicationService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaApplicationService(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public CategoriaDTO AdicionarCategoria(CategoriaDTO categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaDTO EditarCategoria(CategoriaDTO categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaDTO ExcluirCategoria(CategoriaDTO categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaDTO ObterCategoriaPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CategoriaDTO> ObterTodasCategorias()
    {
        throw new NotImplementedException();
    }
}
