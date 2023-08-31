using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;

namespace Jitu_udemy.Services.Iservices{
    public interface IUserService{
        //Add
        Task<string> AddUserAsync(User user);

        //Update
        Task<string> UpdateUserAsync(User user);

        //Delete
        Task<string> DeleteUserAsync(User user);

        //Get All USers
        Task<IEnumerable<User>> GetAllUsersAsync();

        //buy course

        Task<string> BuyCourse(BuyCourse buyCourse);
        Task <User> GetUserByIdAsync(Guid id);
    }
}