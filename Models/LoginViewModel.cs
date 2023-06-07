using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PenaltyCalculation_7.Models;

public class LoginViewModel
{
[Key]
public string? Username { get; set; }

[Required]
[DataType(DataType.Password)]
public string? Password { get; set; }
}

