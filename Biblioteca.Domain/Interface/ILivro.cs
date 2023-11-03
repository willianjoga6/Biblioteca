using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivro
    {
        Task<List<ResponseGetLivro>> GetLivro(int idLivro);
    }
}