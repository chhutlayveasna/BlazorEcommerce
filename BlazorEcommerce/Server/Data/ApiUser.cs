using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.Server.Data
{
    public class ApiUser : IdentityUser
    {
        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }
    }
}
