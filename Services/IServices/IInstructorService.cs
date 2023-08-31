using Jitu_Udemy.Entities;

namespace Jitu_Udemy.Services.Iservices{
    public interface IInstructorService{
           //Add
        Task<string> AddInstructorAsync(Instructor instructor);

        //Update
        Task<string> UpdateInstructorAsync(Instructor instructor);

        //Delete
        Task<string> DeleteInstructorAsync(Instructor instructor);

        //Get All USers
        Task<IEnumerable<Instructor>> GetAllInstructorsAsync();

        Task <Instructor> GetUserByIdAsync(Guid id);
    }
}