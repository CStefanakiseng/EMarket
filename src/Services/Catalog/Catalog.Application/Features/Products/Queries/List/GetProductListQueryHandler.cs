using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductListQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetAllProductsAsync();
            var result = _mapper.Map<List<ProductViewModel>>(productList.ToList());
            return result;
        }
    }
}
