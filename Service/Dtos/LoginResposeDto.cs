using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class LoginResposeDto<T>
    {
        public T Element { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public ICollection<string> Errors { get; set; }
    }
}
