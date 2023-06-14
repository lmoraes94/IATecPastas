using ProjetoFinal.Models;

namespace ProjetoFinal.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        void CreateUser(User user);
        // Outros métodos de negócio relacionados aos usuários
    }
}
