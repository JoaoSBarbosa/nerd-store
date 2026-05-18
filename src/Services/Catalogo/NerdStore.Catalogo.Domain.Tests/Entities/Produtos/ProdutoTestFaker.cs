using NerdStore.Catalogo.Domain.Entities;
using NerdStore.Catalogo.Domain.Tests.Common;
using NerdStore.Catalogo.Domain.ValuesObject;

namespace NerdStore.Catalogo.Domain.Tests.Entities.Produtos;

public class ProdutoTestFaker : BaseFaker
{
    public string ObterNomeFaker()
    {
        var nome = Faker.Commerce.ProductName();
        return nome.Length > 100 ? nome[..100] : nome;
    }

    public string ObterDescricaoFaker()
    {
        var descricao = Faker.Commerce.ProductDescription();
        return descricao.Length > 300 ? descricao[..300] : descricao;
    }


    public Produto ObterProdutoFaker(bool ativo, decimal valor, string imagem, Guid idCategoria, Dimensoes dimensoes)
    {
        var produto = new Produto(
            ObterNomeFaker(),
            ObterDescricaoFaker(),
            ativo,
            valor,
            DateTimeOffset.Now,
            imagem,
            idCategoria,
            dimensoes
        );
        return produto;
    }
}