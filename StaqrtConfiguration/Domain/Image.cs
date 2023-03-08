using System.ComponentModel.DataAnnotations;

public class Image
{
  
    public int Id { get; set; }
    [MaxLength(50)]
    public string ImageName { get; set; }
    [MaxLength(100)]
    public string ImageUrl { get; set; }
    [MaxLength(150)]
    public string ImageDescription { get; set; }
    public int?width { get; set; }
    public int? length { get; set; }
    public int? height { get; set; }
    public Product Product { get; private set; }
    private Image() : this(null!, null! , null!, 0, 0, 0, null!) { }
    public Image( string imageName, string imageUrl, string imageDescription, int? width, int? length, int? height, Product product)
    {
        ImageName = imageName;
        ImageUrl = imageUrl;
        ImageDescription = imageDescription;
        this.width = width;
        this.length = length;
        this.height = height;
        Product = product;
    }

}

