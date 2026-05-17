
using NerdStore.Core.DomainObjects.Interfaces;
using NerdStore.Core.DomainObjects.Model;
using NerdStore.Core.Validations;

namespace NerdStore.Catalogo.Domain.Entities;

public class Categoria : Entity, IAggregateRoot
{

    public string Nome { get; private set; }
    public string? Descricao { get; private set; }
    public bool IsAtivo { get; private set; }
    public int Codigo { get; private set; }

    public Categoria(string nome, string descricao, bool isAtivo, int codigo)
    {
        Nome = nome;
        Descricao = descricao;
        IsAtivo = isAtivo;
        Codigo = codigo;

        Validar();
    }

    public void Desativar() => IsAtivo = false;
    public void Ativar() => IsAtivo = true;

    public void Atualizar(string? nome, string? descricao)
    {
        if (!string.IsNullOrWhiteSpace(nome)) Nome = nome;
        if (!string.IsNullOrWhiteSpace(descricao)) Descricao = descricao;
    }
    public void RemoverDescricao() => Descricao = null;


    private void Validar()
    {
        Validacoes.ValidarSeVazio(Nome, "O campo nome não pode estar vazio");
        Validacoes.ValidarCaracteres(Nome, 100, 5, "O campo nome deve conter no máximo 100 caracteres e no mínimo 5 caracteres");
        if (Descricao != null) Validacoes.ValidarCaracteres(Descricao, 1000, "O campo descrição deve conter no máximo 1000 caracteres");
        Validacoes.ValidarSeMenorIgualMinimo(Codigo, 0, "O campo código deve ser maior que zero");
    }
}