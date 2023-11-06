using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;

namespace Biblioteca.Core
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public List<ResponseGetLivro> ConsultarLivro(int idLivro)
        {
            try
            {
                var retornoGetLivro = _livroRepository.ConsultarLivroRepository(idLivro);

                return retornoGetLivro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InserirLivro(RequestLivro requestLivro)
        {
            _livroRepository.InserirLivro(requestLivro);
        }

    }
}