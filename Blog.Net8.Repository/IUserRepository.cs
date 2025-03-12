using Blog.Net8.Model;

namespace Blog.Net8.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
    }
}
