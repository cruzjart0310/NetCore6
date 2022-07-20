using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class TeamUser
    {
        public int Id { get; set; }

        [ForeignKey("UserIdFK")]
        public string UserId { get; set; }
        //[NotMapped]
        public User User { get; set; }

        [ForeignKey("UserResponsibleIdFK")]
        public string UserResponsibleId { get; set; }
        //[NotMapped]
        public User UserResponsible { get; set; }

        [ForeignKey("TeamAssignedIdFK")]
        public int TeamAssignedId { get; set; }
        //[NotMapped]
        public Team TeamAssigned { get; set; }
        public Byte Current { get; set; }
        public DateTime DateInit { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
