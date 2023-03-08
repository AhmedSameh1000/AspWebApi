using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Customer
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Email { get; set; }
    [MaxLength(50)]
    public string UserName { get; set; }
    [MaxLength(50)]
    public string Password { get; set; }
    [MaxLength(50)]
    public string City { get; set; }
    [MaxLength(50)]
    public string FullAddress { get; set; }
    [MaxLength(50)]
    public string PhoneNumber { get; set; }

    public DateTime RegDate { get; set; }

    public  Gender Gender { get; set; }
   
    public  Govermate Govermate { get; set; }

    public IEnumerable<Order> Order { get => _Order!; }
    private List<Order> _Order;

    public IEnumerable<Wishlist> wishlists { get => _Wishlist!; }
    private List<Wishlist> _Wishlist;

    public IEnumerable<CardVisa> CardVisa { get => _CardVisa!; }
    private  List<CardVisa> _CardVisa;

    public IEnumerable<Review> Reviews { get => _reviews!; }
    private List<Review> _reviews ; 

    public Customer( string name, string email, string userName, string password, string city, string fullAddress, string phoneNumber, DateTime regDate, Gender gender, Govermate govermate)
    {
        Name = name;
        Email = email;
        UserName = userName;
        Password = password;
        City = city;
        FullAddress = fullAddress;
        PhoneNumber = phoneNumber;
        RegDate = regDate;
        Gender = gender;
        Govermate = govermate;
        _reviews = new List<Review>();
        _CardVisa = new List<CardVisa>();
        _Wishlist = new List<Wishlist>();
        _Order = new List<Order>();
    }
    private Customer() : this(null!, null!,null!,null!,null!,null!,null!,DateTime.Now,Gender.Male, null!) { }
}
