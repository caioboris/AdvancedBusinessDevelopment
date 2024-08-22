using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces;

public interface ICategoriaRepository
{
    CategoriaEntity ObterPorId(int id);
    IEnumerable<CategoriaEntity> ObterTodos();
    CategoriaEntity Adicionar(CategoriaEntity categoria);
    CategoriaEntity Editar(CategoriaEntity categoria);
    CategoriaEntity Excluir(CategoriaEntity categoria);
}
