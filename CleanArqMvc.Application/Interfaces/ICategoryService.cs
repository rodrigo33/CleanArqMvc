using CleanArqMvc.Application.DTOs;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCategories();

        Task<CategoryDto> GetById(int? id);

        Task Add(CategoryDto categoryDto);

        Task Update(CategoryDto categoryDto);

        Task Remove(int? id);
    }
}
//List

