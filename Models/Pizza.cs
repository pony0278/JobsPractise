
using System.Diagnostics.CodeAnalysis;

namespace PizzaKing.Models;

[method: SetsRequiredMembers]
public class Pizza(string name, string shortDescription)
{
    public int Id {get;set;}
    public required string Name { get; set; } = name;
    public required string ShortDescription {get;set;} = shortDescription;
    public string? LongDescription {get;set;}
    public decimal Price {get;set;}
    public string? ImageUrl {get;set;}
    public bool IsInStock {get;set;}
}