using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductListQuery : IRequest<List<ProductViewModel>>
    {
    }
}
