using Jitu_Udemy.Data;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Services.Iservices;
using Microsoft.EntityFrameworkCore;

namespace Jitu_Udemy.Services{
    public class InstructorService : IInstructorService
    {
        private readonly ApplicationDbContext _context;

        public InstructorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> AddInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();
            return "Instructor added successfully";
        }

        public async Task<string> DeleteInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();
            return "Instructor deleted successfully";
        }

        public async Task<IEnumerable<Instructor>> GetAllInstructorsAsync()
        {
            return await _context.Instructors.ToListAsync();
        }

        public async Task<Instructor> GetUserByIdAsync(Guid id)
        {
            return await _context.Instructors.Where(x=>x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<string> UpdateInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            await _context.SaveChangesAsync();
            return "Instructor updated successfully";
        }
    }
}