using NerdStore.Core.Validations;

namespace NerdStore.Catalogo.Domain.ValuesObject
{
    public class Dimensoes
    {
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Profundidade { get; private set; }

        public Dimensoes(int altura, int largura, int profundidade)
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

            Validar();
        }
        public string DescricaoFormatada() => $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        public override string ToString() => DescricaoFormatada();
        private void Validar()
        {
            Validacoes.ValidarSeMenorIgualMinimo(Altura, 1, "O campo altura deve ser maior que zero");
            Validacoes.ValidarSeMenorIgualMinimo(Largura, 1, "O campo largura deve ser maior que zero");
            Validacoes.ValidarSeMenorIgualMinimo(Profundidade, 1, "O campo profundidade deve ser maior que zero");
        }
    }
}