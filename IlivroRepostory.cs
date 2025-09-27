using System.Collections.Generic;

using EstudoProva.Models;

namespace BibliotecaAPI.Repositories
{
    public interface ILivroRepository
    {
        void Adicionar(LivroViewModel livro);
        List<LivroViewModel> ObterTodos();
    }
}
