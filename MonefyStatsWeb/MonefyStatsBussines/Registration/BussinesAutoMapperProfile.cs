using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MonefyStats.Bussines.Models;
using MonefyStats.Repository.Models;

namespace MonefyStats.Bussines.Registration
{
    public class BussinesAutoMapperProfile : Profile
    {
        public BussinesAutoMapperProfile()
        {
            CreateMap<FileBussines, FileEntity>()
                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.UserId, opt => opt.Ignore());

            CreateMap<FileEntity, FileBussines>();
        }
    }
}
