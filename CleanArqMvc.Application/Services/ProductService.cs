using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Application.Interfaces;
using CleanArqMvc.Application.Products.Commands;
using CleanArqMvc.Application.Products.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ProductService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null)
            {
                throw new Exception($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productsQuery);
            return _mapper.Map<IEnumerable<ProductDto>>(result);
        }

        public async Task<ProductDto> GetById(int? id)
        {
            var productEntity = new GetProductByIdQuery(id.Value);

            if (productEntity == null)
            {
                throw new Exception($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productEntity);
            return _mapper.Map<ProductDto>(result);
        }

        /*public async Task<ProductDto> GetProductCategory(int? id)
        {
            var productEntity = new GetProductByIdQuery(id.Value);

            if (productEntity == null)
            {
                throw new Exception($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productEntity);
            return _mapper.Map<ProductDto>(result);
        }*/

        public async Task Add(ProductDto productDto)
        {
            var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDto);
            await _mediator.Send(productCreateCommand);
        }

        public async Task Update(ProductDto productDto)
        {
            var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDto);
            await _mediator.Send(productUpdateCommand);
        }

        public async Task Remove(int? id)
        {
            var productRemoveCommand = new ProductRemoveCommand(id.Value);

            if (productRemoveCommand == null)
            {
                throw new Exception($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productRemoveCommand);
        }
    }
}
