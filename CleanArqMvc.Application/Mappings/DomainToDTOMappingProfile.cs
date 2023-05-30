using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Domain.Entities;

namespace CleanArqMvc.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
