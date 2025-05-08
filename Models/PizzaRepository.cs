
namespace PizzaKing.Models;

public class PizzaRepository : IPizzaRepository
{
    private readonly AppDbContext _dbContext;

    public PizzaRepository(AppDbContext context) 
    {
        _dbContext = context;
    }

    public IEnumerable<Pizza> GetAllPizzas()
    {
        return _dbContext.Pizzas;
    }

    public Pizza? GetPizzaById(int id)
    {
        return _dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
    }
}