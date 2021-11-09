using AutoMapper;
using DOLPHIN.DTO;
using DOLPHIN.Model;
using System;

namespace DOLPHIN.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            this.CreateMap<News, ArticlesDto>();
            this.CreateMap<ArticlesDto, News>();
        }
    }
}
