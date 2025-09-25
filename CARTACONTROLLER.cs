using ExercrioProvaAnoPassado.Model;
using ExercrioProvaAnoPassado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ExercrioProvaAnoPassado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly ICartaRepository _cartaRepository;
        private readonly ILogger<CartaController> _logger;

        public CartaController(ICartaRepository cartaRepository, ILogger<CartaController> logger)
        {
            _cartaRepository = cartaRepository ?? throw new ArgumentNullException(nameof(cartaRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carta>> ObterTodasCartas()
        {
            try
            {
                _logger.LogInformation("Obtendo todas as cartas");
                var cartas = _cartaRepository.ObterCartas();
                _logger.LogInformation($"Total de cartas obtidas: {cartas.Count()}");
                return Ok(cartas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter cartas");
                return StatusCode(500, "Erro interno do servidor");
            }
        }

        [HttpGet("{nome}")]
        public ActionResult<Carta> ObterCartaPorNome(string nome)
        {
            try
            {
                _logger.LogInformation("Obtendo carta para o nome: {Nome}", nome);
                var carta = _cartaRepository.ObterCartaPorNome(nome);
                if (carta == null)
                {
                    _logger.LogWarning("Carta não encontrada para o nome: {Nome}", nome);
                    return NotFound($"Carta não encontrada para o nome: {nome}");
                }
                _logger.LogInformation("Carta encontrada para o nome: {Nome}", nome);
                return Ok(carta);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter carta para o nome: {Nome}", nome);
                return StatusCode(500, "Erro interno do servidor");
            }
        }

        [HttpPost]
        public ActionResult<Carta> AdicionarCarta([FromBody] Carta carta)
        {
            try
            {
                if (carta == null)
                {
                    _logger.LogWarning("Carta nula recebida");
                    return BadRequest("A carta não pode ser nula");
                }

                var cartaAdicionada = _cartaRepository.AdicionarCarta(carta);
                _logger.LogInformation("Carta adicionada com sucesso: {Id}", cartaAdicionada.Id);
                return CreatedAtAction(nameof(ObterCartaPorNome), new { nome = cartaAdicionada.NomeCrianca }, cartaAdicionada);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar carta");
                return StatusCode(500, "Erro interno do servidor");
            }
        }
    }
}