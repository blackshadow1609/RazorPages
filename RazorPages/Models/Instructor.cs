using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
	public class Instructor
	{
		public int ID { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Фамилия")]
		[RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
		public string LastName { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Имя")]
		[RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
		public string FirstName { get; set; }

		[DataType(DataType.Date)]
		[DisplayName("Дата приема на работу")]
		public DateTime HireDate { get; set; }

		[DisplayName("Инструктор")]
		public string FullName
		{
			get => $"{LastName} {FirstName}";
		}

		//Nav.properties:
		public ICollection<Course> Courses { get; set; }
		public OfficeAssigment OfficeAssigment { get; set; }
	}
}
