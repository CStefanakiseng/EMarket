using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Features.Products
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            var result = await _productRepository.UpdateProductAsync(product);
            return result;
        }
    }
}
