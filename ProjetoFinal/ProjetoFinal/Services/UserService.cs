using ProjetoFinal.Models;
using ProjetoFinal.Repositories;

namespace ProjetoFinal.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(User user)
        {
            // Realize validações e lógica de negócio antes de adicionar o usuário
            _userRepository.Add(user);
        }

        // Implemente os demais métodos do serviço
    }
}