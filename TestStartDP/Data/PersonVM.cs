using System.ComponentModel.DataAnnotations;

namespace TestStartDP.Data
{
    public class PersonVM
    {
        public int IdPerson { get; set; }

        [Required(ErrorMessage = "Полето 'Име' е задължително!")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Полето 'Фамилия' е задължително!")]
        [StringLength(100)]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "Полето 'ЕГН' е задължително!")]
        public string Indent { get; set; }
        public DateTime? BirthDate { get; set; }

        public string? Sex { get; set; }

    }
}
