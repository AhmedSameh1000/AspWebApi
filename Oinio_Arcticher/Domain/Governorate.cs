using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Govermate
{
   
    public int Id { get; set; }

    public string? GovName { get; set; }

    public  List<Customer> Customer = new List<Customer>();
}




