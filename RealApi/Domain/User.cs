using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class User
{
   
    public int Id { get; set; }
    [MaxLength(50)]
    public string? UserFullName { get; set; }
    [MaxLength(50)]
    public string? UserUserName { get; set; }
    [MaxLength(50)]
    public string? UserPassword { get; set; }
    [MaxLength(50)]
    public string? UserMail { get; set; }
    public Role? Role { get; set; }
}

