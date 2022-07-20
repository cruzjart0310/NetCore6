using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.Contracts.IGenericAccountRepository;

namespace DataAccess.Contracts
{
    public interface IAccountRepository : IGenericAccountRepository<User>
    {

    }
}
