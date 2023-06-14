using ProjetoFinal.Models;

namespace ProjetoFinal.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
        void Add(User user);
    }
}
