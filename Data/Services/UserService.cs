using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Services
{
    public class UserService
    {
        private readonly ProjectContext _context;

        public UserService(ProjectContext context)
        {
            _context = context;
        }

        // Create a new user
        public async Task<User> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        // Update an existing user
        public async Task<User> UpdateUser(int id, User updatedUser)
        {
            var existingUser = await _context.Users.FindAsync(id);
            if (existingUser == null) return null;

            existingUser.Name = updatedUser.Name;
            existingUser.PhoneNumber = updatedUser.PhoneNumber;
            existingUser.EmailAddress = updatedUser.EmailAddress;
            existingUser.Password = updatedUser.Password;
            existingUser.LastLogin = updatedUser.LastLogin;

            await _context.SaveChangesAsync();
            return existingUser;
        }

        // Get a user by ID
        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        // Get all users
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // Delete a user
        public async Task<bool> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
