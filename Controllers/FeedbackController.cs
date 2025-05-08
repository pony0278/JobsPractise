using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaKing.Models;

namespace PizzaKing.Controllers;

[Authorize]
[Controller]
public class FeedbackController : Controller
{
	private readonly IFeedbackRepository _feedbackRepo;

	public FeedbackController(IFeedbackRepository feedbackRepository)
	{
		_feedbackRepo = feedbackRepository;
	}

	public ActionResult Index() 
	{
		return View();
	}

	[HttpPost]
	public ActionResult CreateFeedback(Feedback feedback) 
	{
        //就是POST請求中請求主體的鍵值對的集合
        //當使用者請求資料有誤的時候，它還可以提供錯誤提示訊息
        // ModelState 存在目的
        // 1. 儲存 POST 請求主體
        // 2. 驗證錯誤訊息
        if (ModelState.IsValid) 
		{
			_feedbackRepo.AddFeedback(feedback);
			return Redirect("FeedbackCompleted");
		}
		
		return View("Index");
	}

	public ActionResult FeedbackCompleted() 
	{
		return View();
	}
}