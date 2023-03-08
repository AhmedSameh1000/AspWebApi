using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class OrdersDetail
{

    public int Id { get; set; }

    public int? CategoryNumber { get; set; }

    public Product? Product { get; set; }
    
    public Order? Order { get; set; }

    public int? Quantity { get; set; }

    public double? SalePrice { get; set; }

    public double? Discount { get; set; }
}

