using AutoMapper;
using Dernek.Core.Dtos;
using Dernek.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<Blog, BlogDto>().ReverseMap();
            CreateMap<Carousel, CarouselDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
