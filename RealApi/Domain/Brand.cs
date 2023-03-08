using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Brand
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string? BrandName { get; set; }

    public IEnumerable<Product> Products { get => _Products!; }
    private IList<Product>? _Products { get; set; }
    public Brand() { }
    public Brand(int id, string? brandName)
    {
        Id = id;
        BrandName = brandName;
        _Products= new List<Product>();
    }
}

