using NerdStore.Catalogo.Domain.Tests.Entities.Categorias;
using NerdStore.Catalogo.Domain.Tests.Entities.Produtos;

namespace NerdStore.Catalogo.Domain.Tests.Fixtures;

public class CatalogoFixture
{
    public CatalogoFixture()
    {
        CategoriaFaker = new CategoriaTestFaker();
        ProdutoFaker = new ProdutoTestFaker();
    }

    public CategoriaTestFaker CategoriaFaker { get; }
    public ProdutoTestFaker ProdutoFaker { get; }
}