using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Domain;
public partial class ECommerceContext : DbContext
{
    public DbSet<Genre> genres { get; set; }
    public DbSet<Movie> movies { get; set; }
    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {

    }
   
}
