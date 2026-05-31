using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Student
    {
        public int ID { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Фамилия может быть не более 50 символов")]
		[DisplayName("Фамилия")]
		[RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage ="Строка содержит недопустимые символы")]
        public string LastName { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Имя может быть не более 50 символов")]
		[DisplayName("Имя")]
		[RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
		public string FirstName { get; set; }
		[DisplayName("Дата регистрации")]
		[DataType(DataType.Date)]
		public DateTime EnrollmentDate { get; set; }

		[Display(Name = "Cтудент")]
		public string FullName
		{
			get => $"{LastName} {FirstName}";
		}

		//Nav.prop.
		public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
