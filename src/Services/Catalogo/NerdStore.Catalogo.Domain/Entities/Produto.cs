
using NerdStore.Core.DomainObjects.Interfaces;
using NerdStore.Core.DomainObjects.Model;
using NerdStore.Core.Exceptions;
using NerdStore.Core.Validations;

namespace NerdStore.Catalogo.Domain.Entities;


public class Produto : Entity, IAggregateRoot
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public bool Ativo { get; private set; }
    public decimal Valor { get; private set; }
    public DateTimeOffset DataCadastro { get; private set; }
    public string Imagem { get; private set; }
    public int QuantidadeEstoque { get; private set; }
    public Guid CategoriaId { get; set; }

    public Categoria Categoria { get; private set; }

    public Produto(
        string nome,
        string descricao,
        bool ativo,
        decimal valor,
        DateTimeOffset dataCadastro,
        string imagem,
        Guid categoriaId
    )
    {
        ValidarProduto(nome, descricao);
        Nome = nome;
        Descricao = descricao;
        Ativo = ativo;
        Valor = valor;
        DataCadastro = dataCadastro;
        Imagem = imagem;
        CategoriaId = categoriaId;

    }

    private void ValidarProduto(string nome, string descricao)
    {
        Validacoes.ValidarSeVazio(nome, "O campo nome é obrigatorio");
        Validacoes.ValidarSeVazio(descricao, "O campo descrição é obrigatorio");

        Validacoes.ValidarCaracteres(nome, 100, 5, "O campo nome deve conter no máximo 100 caracteres e no mínimo 5 caracteres");
        Validacoes.ValidarCaracteres(descricao, 1000, 5, "O campo descrição deve conter no máximo 1000 caracteres e no mínimo 5 caracteres");

    }

    public void Ativar() => Ativo = true;
    public void Desativar() => Ativo = false;

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade < 0) throw new Exception("A quantidade a ser adicionada deve ser maior que zero.");

        QuantidadeEstoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (QuantidadeEstoque < quantidade) throw new Exception("Não há estoque suficiente para remover a quantidade solicitada.");
        if (quantidade < 0) quantidade *= -1;

        QuantidadeEstoque -= quantidade;
    }

    public bool PossuiEstoque(int quantidade) => QuantidadeEstoque >= quantidade;

    public void AlterarCategoria(Categoria categoria)
    {
        if (categoria is null) throw new Exception("A categoria não pode ser nula.");
        Categoria = categoria;
        CategoriaId = categoria.Id;
    }

    public void AlterarDescricao(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao)) throw new Exception("A descrição do produto não pode ser nula ou vazia.");
        Descricao = descricao;
    }
}