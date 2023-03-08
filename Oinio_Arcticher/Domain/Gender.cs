using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Gender
{
    
    public int Id { get; set; }

    public string? GenderName { get; set; }

    public List<Customer> Customer = new List<Customer>();
}


