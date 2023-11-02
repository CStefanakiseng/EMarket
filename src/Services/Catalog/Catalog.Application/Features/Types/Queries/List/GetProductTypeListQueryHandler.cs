using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using MediatR;

namespace Catalog.Application.Features.Types
{
    public class GetProductTypeListQueryHandler : IRequestHandler<GetProductTypeListQuery, List<ProductTypeViewModel>>
    {
        private readonly ITypeRepository _productTypeRepository;
        private readonly IMapper _mapper;

        public GetProductTypeListQueryHandler(ITypeRepository productTypeRepository, IMapper mapper)
        {
            _productTypeRepository = productTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductTypeViewModel>> Handle(GetProductTypeListQuery request, CancellationToken cancellationToken)
        {
            var typeList = await _productTypeRepository.GetAllProductTypesAsync();
            var result = _mapper.Map<List<ProductTypeViewModel>>(typeList.ToList());
            return result;
        }
    }
}
