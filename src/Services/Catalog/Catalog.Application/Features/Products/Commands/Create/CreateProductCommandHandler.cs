using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Features.Products
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductViewModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public async Task<ProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            var createdProduct = await _productRepository.CreateProductAsync(product);
            var result = _mapper.Map<ProductViewModel>(createdProduct);
            return result;
        }
    }
}
