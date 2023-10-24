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

        public async Task<ResponseGetLivro> ConsultaLivro()
        {
            try
            {
                var retornoGetLivro = _livroRepository.ConsultaLivroRepository();

                return await retornoGetLivro;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}