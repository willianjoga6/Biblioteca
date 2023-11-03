using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;


namespace Biblioteca.Application
{
    public class Livro : ILivro
    {
        private readonly ILivroConsulta _livroConsulta;

        public Livro(ILivroConsulta livroConsulta)
        {
            _livroConsulta = livroConsulta;
        }

        public async Task<List<ResponseGetLivro>> GetLivro(int idLivro)
        {
			try
			{
                var retornoGetLivro = _livroConsulta.ConsultaLivro(idLivro);

                return await retornoGetLivro;
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
