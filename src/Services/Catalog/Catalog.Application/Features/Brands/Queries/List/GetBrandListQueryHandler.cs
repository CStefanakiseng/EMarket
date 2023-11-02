using AutoMapper;
using Catalog.Application.Interfaces.Repositories;
using MediatR;

namespace Catalog.Application.Features.Brands
{
    public class GetBrandListQueryHandler : IRequestHandler<GetBrandListQuery, List<BrandViewModel>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetBrandListQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<List<BrandViewModel>> Handle(GetBrandListQuery request, CancellationToken cancellationToken)
        {
            var brandList = await _brandRepository.GetAllProductBrandsAsync();
            var result = _mapper.Map<List<BrandViewModel>>(brandList.ToList());
            return result;
        }
    }
}
