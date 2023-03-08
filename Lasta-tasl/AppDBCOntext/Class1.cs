using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using Microsoft.EntityFrameworkCore;



public partial class ECommerceContext : DbContext
{


    public DbSet<Category> Categories { get; set; }

    public DbSet<Image> Images { get; set; }

    public DbSet<Product> Products { get; set; }
    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {

    }
   
}
