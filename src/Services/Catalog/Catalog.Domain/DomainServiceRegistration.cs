﻿using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Domain
{
    public static class DomainServiceRegistration
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            return services;
        }
    }
}