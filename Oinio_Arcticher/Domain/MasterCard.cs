using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class MasterCard
{
    public string Id { get; set; } = null!;

    public DateTime? MasterExpDate { get; set; }

    public decimal? MasterBalance { get; set; }

    public  List<Customer> Customer = new List<Customer>();
}


