using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;


namespace Biblioteca.Application
{
    public class Livro : ILivro
    {
        private readonly ILivroService _livroConsulta;
        private readonly ILivroService _livroService;

        public Livro(ILivroService livroConsulta, ILivroService livroService)
        {
            _livroConsulta = livroConsulta;
            _livroService = livroService;
        }

        public ResponseInserirLivro InserirLivro(RequestLivro requestLivro)
        {
            _livroService.InserirLivro(requestLivro);

            var retornoInserirLivro = new ResponseInserirLivro("Livro inserido com sucesso");

            return retornoInserirLivro;
        }

        public List<ResponseGetLivro> GetLivro(int idLivro)
        {
			try
			{
                var retornoGetLivro = _livroConsulta.ConsultarLivro(idLivro);

                return retornoGetLivro;
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
