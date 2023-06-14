using ProjetoFinal.Models;

namespace ProjetoFinal.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly YourDbContext _dbContext;

        public UserRepository(YourDbContext dbContext) => _dbContext = dbContext;

        public User GetById(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        
    }
}
