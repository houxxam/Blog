using Models;

namespace API.Repositories
{
    public interface IUserRepositorie
    {
        Task<List<User>> GetUsersAsync();
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserAsync(int id);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
