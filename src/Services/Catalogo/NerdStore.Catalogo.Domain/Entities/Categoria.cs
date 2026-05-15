
using NerdStore.Core.DomainObjects.Interfaces;
using NerdStore.Core.DomainObjects.Model;

namespace NerdStore.Catalogo.Domain.Entities;

public class Categoria: Entity, IAggregateRoot
{

    public string Nome { get; private set; }
    public string? Descricao { get; private set; }
    public bool IsAtivo { get; private set; }

    public Categoria(string nome, string descricao, bool isAtivo)
    {
        Nome = nome;
        Descricao = descricao;
        IsAtivo = isAtivo;
    }
}