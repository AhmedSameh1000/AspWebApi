using System.ComponentModel.DataAnnotations;

public class categoryDto
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? CatName { get; set; }
    [MaxLength(200)]
    public string? CatDescription { get; set; }
    [Range(0, 100)]
    public Category? ParentCategory { get; set; }
}