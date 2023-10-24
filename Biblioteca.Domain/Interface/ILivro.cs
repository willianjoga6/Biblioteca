using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivro
    {
        Task<ResponseGetLivro> GetLivro();
    }
}