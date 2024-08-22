using Ecommerce.Produtos.Domain.Dtos;

namespace Ecommerce.Produtos.Domain.Interfaces;

public interface ICategoriaApplicationService
{
    CategoriaDTO ObterCategoriaPorId(int id);
    IEnumerable<CategoriaDTO> ObterTodasCategorias();
    CategoriaDTO AdicionarCategoria(CategoriaDTO categoria);
    CategoriaDTO EditarCategoria(CategoriaDTO categoria);
    CategoriaDTO ExcluirCategoria(CategoriaDTO categoria);
}
