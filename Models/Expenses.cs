using System.ComponentModel.DataAnnotations;

namespace finance_app.Models;

public class Expense {
    public int Id {get; set;}
    [Required]
    public required string Description { get; set; }
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public double Amount {get; set;}
    [Required]
    public required string Category {get; set;}
    public DateTime Date {get; set;} = DateTime.Now;
}