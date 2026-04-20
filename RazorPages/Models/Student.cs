using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Nav.properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
