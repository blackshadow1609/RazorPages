using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
	public class OfficeAssigment
	{
		[Key]
		public int InstructorID { get; set; }

		[StringLength(50)]
		[DisplayName("Адрес офиса")]
		public string Location { get; set; }

		//N/P:
		public Instructor Instructor { get; set; }
	}
}
