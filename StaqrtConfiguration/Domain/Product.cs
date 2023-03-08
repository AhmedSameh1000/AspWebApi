using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Product
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }

    public int UnitPrice { get; set; }

    public double? DiscountPercent { get; set; }
    [MaxLength(200)]
    public string Discription { get; set; }

    public DateTime InsertingDate { get; set;}

    public Brand Brand { get; set; }
    public Category Category { get; set; }

    public IEnumerable<Wishlist> Wishlist { get => _wishlists; }
    private IList<Wishlist> _wishlists;

    public IEnumerable<Review> Reviews { get =>_Reviews; }
    private IList<Review> _Reviews;

    public IEnumerable<Image> Images { get => _Imgs; }
    private IList<Image> _Imgs;

    private Product() : this(null!, 0, null!, DateTime.Now, null!, null!,0) { }
    public Product(string name, int unitPrice, string discription, DateTime insertingDate, Brand brand, Category category, double? discountPercent)
    {
        Name = name;
        UnitPrice = unitPrice;
        DiscountPercent = discountPercent;
        Discription = discription;
        InsertingDate = insertingDate;
        Brand = brand;
        Category = category;
        _wishlists=new List<Wishlist>();
        _Reviews = new List<Review>();
        _Imgs = new List<Image>();
      
    }
    public bool AddImg(Image image)
    {
        if (_Imgs.FirstOrDefault(s => s.Id == image.Id) is null)
        {
            _Imgs.Add(image);
            return true;
        }
        else
        {
            return false;
        }
    }

}




