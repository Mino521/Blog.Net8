using Blog.Net8.IService;
using Blog.Net8.Model;
using Blog.Net8.Repository;

namespace Blog.Net8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> GetUsers()
        {
            var userRepository = new UserRepository();
            var users = await userRepository.GetUsers();
            return users.Select(d => new UserVo() { UserName = d.Name ?? string.Empty }).ToList();
        }
    }
}
