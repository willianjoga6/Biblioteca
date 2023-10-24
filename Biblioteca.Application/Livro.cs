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

        public async Task<ResponseGetLivro> GetLivro()
        {
			try
			{
                var retornoGetLivro = _livroConsulta.ConsultaLivro();

                return await retornoGetLivro;
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
