using NerdStore.Catalogo.Domain.Tests.Common;
using NerdStore.Catalogo.Domain.Tests.Fixtures;

namespace NerdStore.Catalogo.Domain.Tests.Collections;

[CollectionDefinition(nameof(CatalogoCollection))]
public class CatalogoCollection : ICollectionFixture<CatalogoFixture>
{
}