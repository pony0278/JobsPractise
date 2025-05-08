
namespace PizzaKing.Models;

public class MockFeedbackRepository : IFeedbackRepository
{
	private List<Feedback> _feedbackList = new();

	public MockFeedbackRepository() 
	{
		InitializeFeedback();
	}

    public void AddFeedback(Feedback feedback)
    {
		_feedbackList.Add(feedback);
    }

    public IEnumerable<Feedback> GetAllFeedbacks()
    {
        return _feedbackList;
    }

	private void InitializeFeedback()
	{
		_feedbackList =
        [
            new() { Id = 1, Name = "阿來克斯", Email = "noname1@hotmail.com", Comments = "真不錯", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 2, Name = "萊克斯", Email = "noname2@hotmail.com", Comments = "好吃", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 3, Name = "克斯", Email = "noname3@hotmail.com", Comments = "亂七八糟", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 4, Name = "克斯", Email = "noname4@hotmail.com", Comments = "有嚼進", CreateTimeUTC = DateTime.UtcNow},
		];
	}

}
