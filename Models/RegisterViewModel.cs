using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PenaltyCalculation_7.Models;

public class RegisterViewModel
{
     
        public int Id { get; set; }
[Key]
public string? Username { get; set; }

[Required]
public string? Firstname { get; set; }

[Required]
public string? Lastname { get; set; }



[Required]
[DataType(DataType.Password)]
public string? Password { get; set; }

[Required]
[DataType(DataType.Password)]
[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
public string? ConfirmPassword { get; set; }

[Required]
public string? Date_Time { get; set; }

[Required]
public string? Contact { get; set; }
}
