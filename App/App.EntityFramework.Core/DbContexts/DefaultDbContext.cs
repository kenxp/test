﻿using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace App.EntityFramework.Core;

[AppDbContext("App", DbProvider.Sqlite)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
