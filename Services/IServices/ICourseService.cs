using Jitu_Udemy.Entities;

namespace Jitu_Udemy.Services.Iservices{
    public interface ICourseService {
        Task<string> AddCourseAsync(Course course);
        Task<string> DeleteCourseAsync(Course course);
        Task<string> UpdateCourseAsync(Course course);
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task <Course> GetCourseByIdAsync(Guid id);
    }
}