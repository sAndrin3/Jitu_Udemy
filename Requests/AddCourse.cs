namespace Jitu_Udemy.Requests{
    public class AddCourse{
       
        public string Name {get; set; } = string.Empty;
        public string Description {get; set; } = string.Empty;
        public string Price {get; set; }
        public Guid InstructorId {get; set; }
    }
}