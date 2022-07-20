using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ResetPassword
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
