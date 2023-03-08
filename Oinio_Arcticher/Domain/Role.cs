using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Role
{
 
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public  ICollection<User> User { get; } = new List<User>();
}


