using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Product
{

    public int Id { get; set; }

    public string? Name { get; set; }

    public int? UnitPrice { get; set; }

    public double? DiscountPercent { get; set; }

    public string? Discription { get; set; }

    public bool? IsValid { get; set; }

    public int? QuantityPerUnit { get; set; }

    public bool? IsFeatured { get; set; }

    public string? Picture { get; set; }

    public DateTime? InsertingDate { get; set;}

    public Brand? Brand { get; set; }
    public Category? Category { get; set; }

    public List<Wishlist> Wishlist = new List<Wishlist>();
}




