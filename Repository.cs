using System.Collections.Generic;
using BibliotecaAPI.Repositories;
using EstudoProva.Models;

namespace EstudoProva.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private static List<LivroViewModel> _livros = new List<LivroViewModel>();

        public void Adicionar(LivroViewModel livro)
        {
            _livros.Add(livro);
        }

        public List<LivroViewModel> ObterTodos()
        {
            return _livros;
        }
    }
}
