using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductByNameQuery : IRequest<List<ProductViewModel>>
    {
        public string Name { get; set; }
    }
}
