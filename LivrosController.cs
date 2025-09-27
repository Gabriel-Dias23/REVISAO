using Microsoft.AspNetCore.Mvc;
using BibliotecaAPI.Repositories;
using EstudoProva.Models;

namespace EstudoProva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivrosController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] LivroViewModel livro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (livro.AnoPublicacao > DateTime.Now.Year)
                return BadRequest("O ano de publicação não pode ser maior que o ano atual.");

            _livroRepository.Adicionar(livro);
            return Ok("Livro cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var livros = _livroRepository.ObterTodos();
            return Ok(livros);
        }
    }
}
