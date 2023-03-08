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

    public IEnumerable<Image> Images { get => _Imgs; }
    private IList<Image> _Imgs;
   
    public Product() { }
    private Product(int x) : this(null!, 0, null!,  null!,0) { }
    public Product(string name, int unitPrice, string discription, Category category, double? discountPercent)
    {
        Name = name;
        UnitPrice = unitPrice;
        DiscountPercent = discountPercent;
        Discription = discription;
       
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




