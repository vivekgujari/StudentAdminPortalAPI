using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels = StudentAdminPortalAPI.DataModels;

namespace StudentAdminPortalAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, DataModels.Student>().ReverseMap();
            CreateMap<Gender, DataModels.Gender>().ReverseMap();
            CreateMap<Address, DataModels.Address>().ReverseMap();
        }
    }
}
