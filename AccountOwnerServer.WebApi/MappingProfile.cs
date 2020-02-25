using AccountOwnerServer.Entities.DataTransferObjects;
using AccountOwnerServer.Entities.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
            CreateMap<Account, AccountDTO>();

            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerForUpdateDto, Owner>();
        }
    }
}
