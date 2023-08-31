namespace Jitu_udemy.Responses{
    public class CourseResponse{
          public Guid Id {get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; }
        public Guid InstructorId { get; set; }
    }
}