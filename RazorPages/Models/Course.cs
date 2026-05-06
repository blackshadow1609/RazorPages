using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Credits { get; set; }

        //Nav.prop.
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
