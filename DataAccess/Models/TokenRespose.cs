using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TokenRespose<T>
    {
        public T Element { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public ICollection<string> Errors { get; set; }
    }
}
