using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Entities.DataTransferObjects
{
    public class OwnerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public IEnumerable<AccountDTO> Accounts { get; set; }
    }
}
