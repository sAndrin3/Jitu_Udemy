namespace Jitu_Udemy.Entities {
    public class Instructor {

        public Guid Id {get; set; }
        public string Name {get; set; } = string.Empty;
        public string Email {get; set; } = string.Empty;
        public string Password {get; set; } = string.Empty;

        public List<Course> Courses {get; set; } = new List<Course>();
    }
}