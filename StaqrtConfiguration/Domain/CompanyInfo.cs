using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class CompanyInfo
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Address { get; set; }
    [MaxLength(50)]
    public string Email { get; set; }
    [MaxLength(50)]
    public string Phone1 { get; set; }


    public CompanyInfo(string name, string address, string email, string phone1)
    {
        Name = name;
        Address = address;
        Email = email;
        Phone1 = phone1;
    }
}
