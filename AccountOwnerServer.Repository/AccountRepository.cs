using AccountOwnerServer.Contracts;
using AccountOwnerServer.Entities;
using AccountOwnerServer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountOwnerServer.Repository
{
    public class AccountRepository : RepositoryBase<Account>,IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }
        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
