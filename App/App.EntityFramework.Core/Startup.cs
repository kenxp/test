﻿using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace App.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabaseAccessor(options =>
        {
            options.AddDbPool<DefaultDbContext>();
        }, "App.Database.Migrations");
    }
}
