using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class CardVisa
{
 
    public string Id { get; set; } = null!;

    [MaxLength(50)]
    public string NameInCard { get; set; }

    public Customer? customer { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }

    public CardVisa(string id, string nameInCard, Customer? customer, PaymentMethod? paymentMethod)
    {
        Id = id;
        NameInCard = nameInCard;
        this.customer = customer;
        PaymentMethod = paymentMethod;
    }
    private CardVisa():this(null!,null!,null,null) { }

}


