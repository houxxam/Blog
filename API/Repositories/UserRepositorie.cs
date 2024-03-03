using API.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API.Repositories
{
    public class UserRepositorie : IUserRepositorie
    {
        private readonly AppDbContext _context;
        public UserRepositorie(AppDbContext context)
        {
            _context = context;
        }

        // Get List Of All Users
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        // Get User  by Id
        public async Task<User> GetUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                return user;
            }
            else
            {

                return null;
            }
        }
        // Create new user
        public async Task<User> CreateUserAsync(User _user)
        {
            var user = await _context.Users.FindAsync(_user.UserName);
            if (user == null)
            {
                user = new User();
                user.UserName = _user.UserName;
                user.Email = _user.Email;
                user.Password = _user.Password;
                user.CreatedAt = DateTime.Now;
                user.UpdatedAt = DateTime.Now;
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;

            }
            else
            {
                return null;
            }
        }

        // update user
        public async Task<User> UpdateUserAsync(User user)
        {

            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null)
            {
                throw new Exception("User not found"); // You can customize the exception message
            }

            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
            existingUser.ProfilePicture = user.ProfilePicture;
            existingUser.Password = user.Password;
            existingUser.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return existingUser;
        }

        // Delete user
        public async Task DeleteUserAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null)
            {
                throw new Exception("User Not Found");
            }
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }






    }
}
