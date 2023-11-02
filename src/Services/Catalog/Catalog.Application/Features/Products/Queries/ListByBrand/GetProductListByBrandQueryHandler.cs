using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductListByBrandQueryHandler : IRequestHandler<GetProductListByBrandQuery, List<ProductViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductListByBrandQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> Handle(GetProductListByBrandQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetProductsByBrandAsync(request.BrandName);
            var result = _mapper.Map<List<ProductViewModel>>(productList.ToList());
            return result;
        }
    }
}
