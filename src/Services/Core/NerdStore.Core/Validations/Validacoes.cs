using NerdStore.Core.Exceptions;

namespace NerdStore.Core.Validations
{
    public class Validacoes()
    {
        public static void ValidarSeIgual(object primaryObject, object secondaryObject, string mensage)
        {
            if (!primaryObject.Equals(secondaryObject)) throw new DomainException(mensage);
        }

        public static void ValidarSeDiferente(object primaryObject, object secondaryObject, string mensage)
        {
            if (primaryObject.Equals(secondaryObject)) throw new DomainException(mensage);
        }
    }

}