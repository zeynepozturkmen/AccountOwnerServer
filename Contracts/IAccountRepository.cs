using AccountOwnerServer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}
