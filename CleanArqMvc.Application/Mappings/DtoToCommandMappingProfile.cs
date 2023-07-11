using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Mappings
{
    public class DtoToCommandMappingProfile : Profile
    {
        public DtoToCommandMappingProfile()
        {
            CreateMap<ProductDto, ProductCreateCommand>();
            CreateMap<ProductDto, ProductUpdateCommand>();
        }
    }
}
