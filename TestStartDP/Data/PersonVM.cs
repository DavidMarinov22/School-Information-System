using System.ComponentModel.DataAnnotations;

namespace TestStartDP.Data
{
    public class PersonVM
    {
        public int IdPerson { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string SecondName { get; set; }

        [Required]
        [StringLength(100)]
        public string FamilyName { get; set; }

        [StringLength(10)]
        public string Indent { get; set; }
        public DateTime? BirthDate { get; set; }

        public string? Sex { get; set; }

    }
}
