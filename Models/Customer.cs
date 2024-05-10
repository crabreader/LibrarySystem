namespace LibrarySystem.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 5)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    [Display(Name="Date of Birth")]
    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<BookLoan>? BookLoans { get; set; }
}
