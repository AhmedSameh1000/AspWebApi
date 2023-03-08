
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Review
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? Phone { get; set; }
    [MaxLength(50)]
    public string? Email { get; set; }
    //public string ReviewMassage { get; set; }

    public IEnumerable<Customer>? customerName { get => _customerName; }
    private IList<Customer>? _customerName;

    public IEnumerable<Product>? Products { get => _Products; }
    private IList<Product>? _Products;

    public Review(string? phone, string? email)
    {
        Phone = phone;
        Email = email;    
        _customerName=new List<Customer>();
        _Products=new List<Product>();
    }
}

