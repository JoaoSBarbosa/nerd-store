
using NerdStore.Core.DomainObjects.Interfaces;
using NerdStore.Core.DomainObjects.Model;
using NerdStore.Core.Exceptions;

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
        if (string.IsNullOrWhiteSpace(nome)) throw new DomainException("O campo nome é obrigatorio");
        if (string.IsNullOrWhiteSpace(descricao)) throw new DomainException("O campo descrição não pode ser nula.");
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