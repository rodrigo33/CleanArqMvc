using CleanArqMvc.Application.Products.Commands;
using CleanArqMvc.Domain.Entities;
using CleanArqMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Products.Handlers
{
    public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public ProductCreateCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Description, request.Price, 
                request.Stock, request.Image);

            if(product == null)
            {
                throw new ApplicationException($"error creating entity");
            }

            product.CategoryId = request.CategoryId;
            return await _productRepository.CreateAsync(product);
        }
    }
}
