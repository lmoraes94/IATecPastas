
public class UserServiceTests
{
    [Fact]
    public void RetornarUsuarioSeExistir()
    {
        // Simule um UserRepository e UserService com dados de teste
        var userRepositoryMock = new Mock<IUserRepository>();
        var userService = new UserService(userRepositoryMock.Object);

        
        int userId = 1;
        var expectedUser = new User { Id = userId, Name = "Leonardo de Moraes", Email = "leonardo@email.com" };
        userRepositoryMock.Setup(repo => repo.GetById(userId)).Returns(expectedUser);

        // Chame o método GetUserById no UserService
        var actualUser = userService.GetUserById(userId);

        
        Assert.Equal(expectedUser, actualUser);
    }

    
}
