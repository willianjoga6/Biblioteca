using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivro
    {
        List<ResponseGetLivro> GetLivro(int idLivro);
        public ResponseInserirLivro InserirLivro(RequestLivro requestLivro);
    }
}