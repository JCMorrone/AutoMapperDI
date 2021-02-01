using AutoMapper;
using AutoMapperDI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDI
{
    public class SarasaMapper: Profile
    {
        public SarasaMapper()
        {
            CreateMap<Sarasa, SarasaVM>()
                .ForMember(x => x.Sarasasa, y => y.MapFrom<SarasaResolver>());
        }
    }
}
