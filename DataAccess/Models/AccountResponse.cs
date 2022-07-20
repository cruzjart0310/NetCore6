using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class AccountResponse<T>
    {
        public T Element { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
