
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Wishlist
{
  
    public int Id { get; set; }

    public Customer? Customer { get; set; }
    public Product? Product { get; set; }
}


