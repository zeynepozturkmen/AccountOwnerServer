using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Contracts
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
