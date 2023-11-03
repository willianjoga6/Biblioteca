using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivroRepository
    {
        Task<List<ResponseGetLivro>> ConsultaLivroRepository(int idLivro);
    }
}