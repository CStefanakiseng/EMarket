using MediatR;

namespace Catalog.Application.Features.Types
{
    public class GetProductTypeListQuery : IRequest<List<ProductTypeViewModel>>
    {
    }
}
