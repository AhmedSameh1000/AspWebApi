using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using Microsoft.EntityFrameworkCore;



public partial class ECommerceContext : DbContext
{

    public DbSet<Brand> Brands { get; set; }

    public DbSet<CardVisa> CardVisas { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<CompanyInfo> CompanyInfos { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Wishlist> Wishlists { get; set; }

    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {

    }
   
}
