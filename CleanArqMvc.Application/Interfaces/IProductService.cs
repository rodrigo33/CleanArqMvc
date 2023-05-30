using CleanArqMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();

        Task<ProductDto> GetById(int? id);

        Task Add(ProductDto productDto);

        Task Update(ProductDto productDto);

        Task Remove(int? id);
    }
}
