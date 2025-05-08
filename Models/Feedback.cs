using System.ComponentModel.DataAnnotations;

namespace PizzaKing.Models;

public class Feedback 
{
    public int Id { get; set; }
    [Required(ErrorMessage = "請留下你的名字")]
    [StringLength(50, ErrorMessage = "名字不能超過50個字元")]
    public required string Name { get; set; }
    [Required(ErrorMessage = "請留下你的email")]
    [StringLength(50, ErrorMessage = "email不能超過50個字元")]
    // [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
    // , ErrorMessage = "請填入正確的email格式")]
    [DataType(DataType.EmailAddress, ErrorMessage = "請填入正確的email格式")]
    public required string Email { get; set; }
    public required DateTime CreateTimeUTC { get; set; }
    [Required(ErrorMessage = "請留下你的評價")]
    [StringLength(500, ErrorMessage = "評價不能超過500個字元")]
    public required string Comments { get; set; }
}