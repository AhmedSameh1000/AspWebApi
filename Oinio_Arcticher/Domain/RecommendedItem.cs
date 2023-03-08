using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class RecommendedItem
{
   
    public int Id { get; set; }

    public string? ProName { get; set; }

    public int? ProUnitPrice { get; set; }

    public string? ProPicture { get; set; }

    public Category? Category { get; set; }
    public string? CatName { get; set; }

    public string? CatDescription { get; set; }

    public string? CatPicture { get; set; }
}



