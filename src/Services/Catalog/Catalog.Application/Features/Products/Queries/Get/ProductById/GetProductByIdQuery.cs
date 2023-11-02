using MediatR;

namespace Catalog.Application.Features.Products
{
    public class GetProductByIdQuery : IRequest<ProductViewModel>
    {
        public string Id { get; set; }
    }
}
