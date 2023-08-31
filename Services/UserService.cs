using Jitu_udemy.Services.Iservices;
using Jitu_Udemy.Data;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;
using Microsoft.EntityFrameworkCore;

namespace Jitu_Udemy.Services{
    public class UserService : IUserService{

        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return "User Created Successfully";
        }

        public Task<string> BuyCourse(BuyCourse buyCourse)
        {
            throw new NotImplementedException();
        }

        public async Task<string> DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return "User Deleted Successfully";
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

       public async Task<User> GetUserByIdAsync(Guid id)
        {
          return await _context.Users.Where(x=>x.Id==id).FirstOrDefaultAsync();
         
        }

        public async Task<string> UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return "User Updated Successfully";
        }

       
    } 
}