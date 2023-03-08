using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class PaymentMethod
{ 
    public int Id { get; set; }
    [MaxLength(50)]
    public string? MethodName { get; set; }

    public IEnumerable<CardVisa> CardVisa { get => _CardVisa; }
    private IList<CardVisa> _CardVisa;
    public Order Order { get; set; }
    public PaymentMethod(int id, string? methodName)
    {
        Id = id;
        MethodName = methodName;
        _CardVisa=new List<CardVisa>();
    }
}


