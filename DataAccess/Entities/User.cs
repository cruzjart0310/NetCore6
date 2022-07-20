using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public bool? IsMarried { get; set; }
        public IEnumerable<TeamUser> Teams { get; set; }
        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public string Url { get; set; }
    }
}
