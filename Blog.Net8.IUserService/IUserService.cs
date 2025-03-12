using Blog.Net8.Model;

namespace Blog.Net8.IService
{
    public interface IUserService
    {
        Task<List<UserVo>> GetUsers();
    }
}
