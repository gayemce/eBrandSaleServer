﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBrandSaleServer.Infrastracture;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastracture(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
