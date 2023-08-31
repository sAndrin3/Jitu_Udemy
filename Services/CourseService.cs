using Jitu_Udemy.Data;
using Jitu_Udemy.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jitu_Udemy.Services.Iservices{
    public class CourseService : ICourseService
    {
    
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> AddCourseAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return "Course added successfully";
        }

        public async Task<string> DeleteCourseAsync(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return "Course deleted successfully";
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(Guid id)
        {
            return await _context.Courses.Where(x=>x.Id==id).FirstOrDefaultAsync();
        }

        public async Task<string> UpdateCourseAsync(Course course )
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
            return "Course updated successfully";
        }
    }
}