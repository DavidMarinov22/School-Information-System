using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestStartDP.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Comment("Връзка с лице")]
        [ForeignKey("IdPerson")]
        public int IdPerson { get; set; }
        public Person Person { get; set; }
    }
}
