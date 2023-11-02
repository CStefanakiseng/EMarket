using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductByNameQueryHandler : IRequestHandler<GetProductByNameQuery, List<ProductViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByNameQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetProductsByNameAsync(request.Name);
            var result = _mapper.Map<List<ProductViewModel>>(productList.ToList());
            return result;
        }
    }
}
