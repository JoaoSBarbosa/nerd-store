using FluentAssertions;
using NerdStore.Catalogo.Domain.Tests.Collections;
using NerdStore.Catalogo.Domain.Tests.Fixtures;
using NerdStore.Catalogo.Domain.ValuesObject;
using NerdStore.Core.Exceptions;

namespace NerdStore.Catalogo.Domain.Tests.Entities.Produtos;

[Collection(nameof(CatalogoCollection))]
public class ProdutoTest
{
    private readonly CatalogoFixture _catalogoFixture;

    public ProdutoTest(CatalogoFixture fixture)
    {
        _catalogoFixture = fixture;
    }


    [Trait("Categoria", "Produto")]
    [Fact(DisplayName = "Deve retornar exception quando objeto for inválido")]
    public void Deve_Retornar_DomainException_Se_ObjetoInvalido()
    {
        var dimensoes = new Dimensoes(10, 10, 10);
        var categoria = _catalogoFixture.CategoriaFaker.ObterCategoria(true);
        var action = () => _catalogoFixture.ProdutoFaker.ObterProdutoFaker(
            true,
            200,
            "",
            categoria.Id,
            dimensoes
        );

        action.Should().Throw<DomainException>();
    }
}