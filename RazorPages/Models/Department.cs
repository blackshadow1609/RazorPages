using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
	public class Department
	{
		public int DepartmentID { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 3)]
		[DisplayName("Кафедра")]
		public string Name { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal Budget { get; set; }

		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }
		public int? InstructorID { get; set; }

		//N/P:
		public Instructor Administrator { get; set; }
		public ICollection<Course> Courses { get; set; }
	}
}
