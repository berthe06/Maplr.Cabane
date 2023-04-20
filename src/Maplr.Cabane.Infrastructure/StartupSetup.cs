﻿using Maplr.Cabane.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Maplr.Cabane.Infrastructure;

public static class StartupSetup
{
    public static void AddDbContext(this IServiceCollection services, string connectionString) =>
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(connectionString)); // will be created in web project root
}
