
namespace PizzaKing.Models;

public class FeedbackRepository : IFeedbackRepository
{
    private readonly AppDbContext _dbContext;

    public FeedbackRepository(AppDbContext context) 
    {
        _dbContext = context;
    }

    public void AddFeedback(Feedback feedback)
    {
        _dbContext.Feedbacks.Add(feedback);
        _dbContext.SaveChanges();
        // _dbContext.SaveChangesAsync();
    }

    public IEnumerable<Feedback> GetAllFeedbacks()
    {
        return _dbContext.Feedbacks;
    }
}