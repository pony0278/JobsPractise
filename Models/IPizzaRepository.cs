namespace PizzaKing.Models;

public interface IPizzaRepository 
{
    IEnumerable<Pizza> GetAllPizzas();
    Pizza? GetPizzaById(int id);
}