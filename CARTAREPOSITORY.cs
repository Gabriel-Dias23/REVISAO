using ExercrioProvaAnoPassado.Model;

namespace ExercrioProvaAnoPassado.Repository
{
    public class CartaRepository : ICartaRepository
    {

        private readonly List<Carta> _cartas;


        private int _nextId = 1;

        private CartaRepository()
        {
            _cartas = new List<Carta>();
            _nextId = 1;
        }
        public Carta AdicionarCarta(Carta carta)
        {
            if (carta == null)
            {
                throw new ArgumentNullException(nameof(carta), "A carta não pode ser nula");
            }
            carta.Id = _nextId++;
            _cartas.Add(carta);
            return carta;
        }
        public IEnumerable<Carta> ObterCartas()
        {
            return _cartas;
        }
        public Carta? ObterCartaPorNome(string nome)
        {
            return _cartas.FirstOrDefault(c => c.NomeCrianca.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public int ObterTotalCartas()
        {
            return _cartas.Count;
        }


    }
}