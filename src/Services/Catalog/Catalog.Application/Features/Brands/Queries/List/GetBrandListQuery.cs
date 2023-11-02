using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Brands
{
    public class GetBrandListQuery: IRequest<List<BrandViewModel>>
    {
    }
}
