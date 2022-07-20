using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class AccountResponseDto<T>
    {
        public T Element { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
