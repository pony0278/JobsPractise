namespace PizzaKing.Models;

public interface IFeedbackRepository 
{
	IEnumerable<Feedback> GetAllFeedbacks();
	void AddFeedback(Feedback feedback);
}