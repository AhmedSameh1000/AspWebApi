using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class PaymentMethod
{
    
    public int Id { get; set; }

    public string? MethodName { get; set; }

    public  List<CardVisa> CardVisa = new List<CardVisa>();

}


