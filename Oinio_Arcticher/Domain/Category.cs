using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Category
{
    public int Id { get; set; }

    public string? CatName { get; set; }

    public string? CatDescription { get; set; }

    public string? CatPicture { get; set; }

    public  List<Product> Product = new List<Product>();
    public List<Brand> Brand = new List<Brand>();
}

