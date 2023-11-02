using MediatR;

namespace Catalog.Application.Features.Products
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string Id { get; set; }
    }
}
