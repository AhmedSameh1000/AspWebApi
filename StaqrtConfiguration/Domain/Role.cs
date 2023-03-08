using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Role
{
 
    public int Id { get; set; }
    [MaxLength(50)]
    public string? RoleName { get; set; }
    [MaxLength(100)]
    public string? RoleDescription { get; set; }

    public  ICollection<User> User { get; } = new List<User>();
}


