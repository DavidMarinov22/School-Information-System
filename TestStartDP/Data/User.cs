using System.ComponentModel.DataAnnotations;

namespace TestStartDP.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string LoginName { get; set; } = string.Empty;
        [Required]
        public string UserRole { get; set; } = string.Empty;
    }
}
