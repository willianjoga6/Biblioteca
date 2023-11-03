using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;

namespace Biblioteca.Core
{
    public class LivroConsulta : ILivroConsulta
    {
        private readonly ILivroRepository _livroRepository;

        public LivroConsulta(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<List<ResponseGetLivro>> ConsultaLivro(int idLivro)
        {
            try
            {
                var retornoGetLivro = _livroRepository.ConsultaLivroRepository(idLivro);

                return await retornoGetLivro;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}