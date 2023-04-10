using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestStartDP.Data
{

    [Table("Person")]
    public class Person
    {
            [Key]
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
