using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Data.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly DataContext _context;

    public CategoriaRepository(Context context)
    {
        _context = context;
    }

    public CategoriaEntity Adicionar(CategoriaEntity categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaEntity Editar(CategoriaEntity categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaEntity Excluir(CategoriaEntity categoria)
    {
        throw new NotImplementedException();
    }

    public CategoriaEntity ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CategoriaEntity> ObterTodos()
    {
        throw new NotImplementedException();
    }
}
