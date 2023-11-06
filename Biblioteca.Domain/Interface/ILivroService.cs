using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivroService
    {
        List<ResponseGetLivro> ConsultarLivro(int IdLivro);
        public void InserirLivro(RequestLivro requestLivro);
    }
}