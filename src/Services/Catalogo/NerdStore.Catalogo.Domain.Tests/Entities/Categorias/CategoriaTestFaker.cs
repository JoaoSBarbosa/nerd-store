using NerdStore.Catalogo.Domain.Entities;
using NerdStore.Catalogo.Domain.Tests.Common;

namespace NerdStore.Catalogo.Domain.Tests.Entities.Categorias;

public class CategoriaTestFaker : BaseFaker
{
    public string ObterNomeCategoria()
    {
        var nome = Faker.Commerce.Categories(1).First();
        return nome.Length > 100 ? nome[..100] : nome;
    }

    public string ObterDescricaoCategoria()
    {
        var descricao = Faker.Commerce.ProductDescription();
        return descricao.Length > 1000 ? descricao[..1000] : descricao;
    }

    public int ObterCodigoCategoria()
    {
        return Faker.Random.Int(1, 999);
    }

    public bool ObterIsAtivo()
    {
        return Faker.Random.Bool();
    }

    public Categoria ObterCategoria(bool isAtivo)
    {
        return new Categoria(
            ObterNomeCategoria(),
            ObterDescricaoCategoria(),
            isAtivo,
            ObterCodigoCategoria());
    }

    public Categoria ObterCategoriaSemDescricao(bool isAtivo)
    {
        return new Categoria(
            ObterNomeCategoria(),
            null,
            isAtivo,
            ObterCodigoCategoria());
    }
}