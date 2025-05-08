using PizzaKing.Models;

namespace PizzaKing.ViewModels;

public class HomeViewModel 
{
	public IList<Pizza> PizzaList {get;set;} = [];
	public IList<Feedback> FeedbackList {get;set;} = [];
}