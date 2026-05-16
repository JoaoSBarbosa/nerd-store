using System.Text.RegularExpressions;
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

        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var lenght = ObterTamanhoString(valor);
            if (lenght > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarCaracteres(string valor, int maximo, int minimo, string mensagem)
        {
            var lenght = ObterTamanhoString(valor);
            if (lenght > maximo || lenght < minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeNulo(object objectValue, string mensage)
        {
            if (objectValue == null) throw new DomainException(mensage);
        }

        public static void ValidarSeVazio(string value, string mensage)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new DomainException(mensage);
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensage)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensage);
        }
        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensage)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensage);
        }
        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensage)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensage);
        }
        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensage)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensage);
        }
        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensage)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensage);
        }
        public static void ValidarExpressaoRegular(string pattern, string valor, string mensage)
        {
            var regex = new Regex(pattern);
            if (!regex.IsMatch(valor)) throw new DomainException(mensage);
        }

        #region ValidarSeMenorIgualMinimo
        public static void ValidarSeMenorIgualMinimo(int valor, int minimo, string mensage)
        {
            if (valor <= minimo) throw new DomainException(mensage);
        }
        public static void ValidarSeMenorIgualMinimo(double valor, double minimo, string mensage)
        {
            if (valor <= minimo) throw new DomainException(mensage);
        }
        public static void ValidarSeMenorIgualMinimo(float valor, float minimo, string mensage)
        {
            if (valor <= minimo) throw new DomainException(mensage);
        }
        #endregion
        public static void ValidarSeFalso(bool valor, string mensage)
        {
            if (!valor) throw new DomainException(mensage);
        }

        public static void ValidarSeVerdadeiro(bool valor, string mensage)
        {
            if (valor) throw new DomainException(mensage);
        }

        private static int ObterTamanhoString(string valor) => valor.Trim().Length;

    }

}