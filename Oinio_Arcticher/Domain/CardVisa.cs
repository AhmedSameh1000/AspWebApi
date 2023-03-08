using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class CardVisa
{
    
    public string Id { get; set; } = null!;

    public string? Month { get; set; }

    public string? Year { get; set; }

    public string? NameInCard { get; set; }

    public string? UserName { get; set; }

    public string? MasterBalance { get; set; }

    public Customer? customer { get; set; }

    public PaymentMethod? PaymentMethod { get; set; }
}


