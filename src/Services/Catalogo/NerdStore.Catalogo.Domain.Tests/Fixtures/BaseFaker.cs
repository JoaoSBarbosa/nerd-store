using Bogus;

namespace NerdStore.Catalogo.Domain.Tests.Common;

public abstract class BaseFaker
{
    protected BaseFaker()
    {
        Faker = new Faker("pt_BR");
    }

    public Faker Faker { get; set; }
}