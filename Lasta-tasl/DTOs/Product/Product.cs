using System.ComponentModel.DataAnnotations;

public class ProductDto
{
    [MaxLength(50)]
    public string Name { get; set; }

    public int UnitPrice { get; set; }

    public double? DiscountPercent { get; set; }
    [MaxLength(200)]
    public string Discription { get; set; }
}