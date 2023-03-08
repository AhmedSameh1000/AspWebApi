using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public partial class Category
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string CatName { get; set; }
    [MaxLength(200)]
    public string CatDescription { get; set; }
    [Range(0, 100)]
    public Category? ParentCategory { get; set; }

    public IEnumerable<Category> SubCategories { get=>_categories;}
    private readonly IList<Category> _categories;

    public IEnumerable<Product> Products { get => _products; }
    private readonly IList<Product> _products;

    public IEnumerable<Brand> Brands { get => _brands; }
    private readonly IList<Brand> _brands;
    

    public Category(string catName, string catDescription, Category? parentCategory = null)
    {
        CatName = catName;
        CatDescription = catDescription;
        ParentCategory = parentCategory;
        _products = new List<Product>();
        _brands = new List<Brand>();
        _categories = new List<Category>();
    }
    private Category() : this(null!, null!, null) { }
    public bool AddSubCategory(Category category)
    {
        if (SubCategories.FirstOrDefault(s => s.CatName == category.CatName)is null)
        {
            _categories.Add(category);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool AddProduct(Product product)
    {

        if (Products.FirstOrDefault(s => s.Name == product.Name) is null)
        {
            _products.Add(product);
            return true;
        }
        else
        {
            return false;
        }
    }
}



