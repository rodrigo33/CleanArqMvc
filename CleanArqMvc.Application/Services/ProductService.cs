using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Application.Interfaces;
using CleanArqMvc.Domain.Entities;
using CleanArqMvc.Domain.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(productsEntity);
        }

        public async Task<ProductDto> GetById(int? id)
        {
            var productsEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(productsEntity);
        }

        public async Task<ProductDto> GetProductCategory(int? id)
        {
            var productsEntity = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDto>(productsEntity);
        }

        public async Task Add(ProductDto productDto)
        {
            var productsEntity = _mapper.Map<Product>(productDto);
            await _productRepository.CreateAsync(productsEntity);
        }
        public async Task Update(ProductDto productDto)
        {
            var productsEntity = _mapper.Map<Product>(productDto);
            await _productRepository.UpdateAsync(productsEntity);
        }

        public async Task Remove(int? id)
        {
            var productsEntity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(productsEntity);
        }
    }
}
