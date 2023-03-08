using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Customer
{
    public int Id { get; set; }

    public string? CustName { get; set; }

    public string? CustMail { get; set; }

    public string? CustUserName { get; set; }

    public string? CustPassword { get; set; }

    public string? CustCity { get; set; }

    public string? CustFullAddress { get; set; }

    public string? CustTel1 { get; set; }

    public string? CustTel2 { get; set; }
   
    public DateTime? CustRegDate { get; set; }

    public string? CustIsBlocked { get; set; }


    public  Gender? Gender { get; set; }

    public  Govermate? Govermate { get; set; }

    public  MasterCard? MasterCard { get; set; }

    public List<Wishlist> Wishlist = new List<Wishlist>();

    public  List<CardVisa> CardVisa = new List<CardVisa>();

}
