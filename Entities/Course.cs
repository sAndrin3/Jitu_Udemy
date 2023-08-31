using System.ComponentModel.DataAnnotations.Schema;

namespace Jitu_Udemy.Entities {
    public class Course {

        public Guid Id {get; set; }
        public string Name {get; set; } = string.Empty;
        public string Description {get; set; } = string.Empty;
        public int Price {get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor {get; set; } = default!;

        public Guid InstructorId {get; set; }
        
        public List<User> users {get; set; } = new List<User>();

    }
}