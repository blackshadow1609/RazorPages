using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public enum Grade { A, B, C, D, F }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText ="No garde")]
        public Grade? Grade { get; set; }

        // Nav.properties
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
