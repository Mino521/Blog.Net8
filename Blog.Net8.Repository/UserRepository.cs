using Blog.Net8.Model;
using Newtonsoft.Json;

namespace Blog.Net8.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> GetUsers()
        {
            await Task.CompletedTask;
            var data = "[{\"Name\":\"John\"},{\"Name\":\"Jane\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data)
                ?? new List<User>();
        }
    }
}
