using CleanArqMvc.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CleanArqMvc.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
