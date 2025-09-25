using ExercrioProvaAnoPassado.Model;

namespace ExercrioProvaAnoPassado.Repository
{
    public interface ICartaRepository
    {
        Carta AdicionarCarta(Carta carta);
        IEnumerable<Model.Carta> ObterCartas();

        Carta? ObterCartaPorNome(string nome);

        int ObterTotalCartas();
    }
}