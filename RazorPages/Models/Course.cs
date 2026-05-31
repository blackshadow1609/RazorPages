using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[DisplayName("Номер")]
		public int CourseID { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 3)]
		[DisplayName("Курс")]
		public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        //Nav.prop.
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public Department Department { get; set; }
    }
}
