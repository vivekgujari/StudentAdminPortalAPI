using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Profiles.AfterMaps;
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
            CreateMap<DataModels.Student, Student>().ReverseMap();

            CreateMap<DataModels.Gender, Gender>().ReverseMap();

            CreateMap<DataModels.Address, Address>().ReverseMap();

            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap<UpdateStudentRequestAfterMap>().ReverseMap();

            CreateMap<AddStudentRequest, DataModels.Student>()
                .AfterMap<AddStudentRequestAfterMap>();
            
        }
    }
}
