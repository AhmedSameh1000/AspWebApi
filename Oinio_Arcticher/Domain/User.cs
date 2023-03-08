using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class User
{
   
    public int Id { get; set; }

    public string? UserFullName { get; set; }

    public string? UserUserName { get; set; }

    public string? UserPassword { get; set; }

    public string? UserMail { get; set; }

    public bool? UserIsBlocked { get; set; }

    public Role? Role { get; set; }
}


