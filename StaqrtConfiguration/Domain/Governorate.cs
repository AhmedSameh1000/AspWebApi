using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Govermate
{
   
    public int Id { get; set; }
    [MaxLength(50)]
    public string GovName { get; set; }

    public IEnumerable<Customer> Customer { get => _Customers; }
    private IList<Customer> _Customers;

    public Govermate(string govName)
    {
        GovName = govName;
        _Customers=new List<Customer>();
    }
}




