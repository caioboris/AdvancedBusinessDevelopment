using Ecommerce.Produtos.Domain.Dtos.Common;
using FluentValidation;

namespace Ecommerce.Produtos.Domain.Dtos;

public class ProdutoDTO : CommonDTO
{
    public int Quantidade { get; set; }
    public int CategoriaId { get; set; }

    public void Validar()
    {
        var validateResult = new ProdutoDtoValidaton().Validate(this);

        if (!validateResult.IsValid)
        {
            throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }
}

internal class ProdutoDtoValidaton : AbstractValidator<ProdutoDTO>
{
    public ProdutoDtoValidaton()
    {
        RuleFor(x => x.Nome)
            .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} deve ter no mínimo 5 caracteres.")
            .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio.");

        RuleFor(x => x.Quantidade)
            .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.Quantidade)} deve conter pelo meno um item.");

        RuleFor(x => x.CategoriaId)
            .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.CategoriaId)} deve conter o valor de uma categoria.");
            
    }
}
