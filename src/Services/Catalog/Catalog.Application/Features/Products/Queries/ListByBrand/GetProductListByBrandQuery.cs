using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductListByBrandQuery : IRequest<List<ProductViewModel>>
    {
        public string BrandName { get; set; }
    }
}
