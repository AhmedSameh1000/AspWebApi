
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }
    [MaxLength(50)]
    public string ShipCity { get; set; }
    [MaxLength(50)]
    public string ShipAddress { get; set; }

    public decimal CartTottalCost { get; set; }

    public Customer? Customer { get; set; } 

    public IEnumerable<PaymentMethod>? PaymentMethod { get => _PaymentMethod; }
    private IList<PaymentMethod>? _PaymentMethod;
    private Order() : this(DateTime.Now, null!, null!, 0,  null!) { }
    public Order(DateTime orderDate, string shipCity, string shipAddress, decimal cartTottalCost, Customer? customer)
    {
        OrderDate = orderDate;
        ShipCity = shipCity;
        ShipAddress = shipAddress;
        CartTottalCost = cartTottalCost;
        Customer = customer;
        _PaymentMethod=new List<PaymentMethod>();
    }
}



