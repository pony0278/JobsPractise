using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaKing.Models;
using PizzaKing.ViewModels;

namespace PizzaKing.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPizzaRepository _pizzaRepository;
    private readonly IFeedbackRepository _feedbackRepository;

    public HomeController(ILogger<HomeController> logger, IPizzaRepository repository, IFeedbackRepository feedback )
    {
        _logger = logger;
        _pizzaRepository = repository;
        _feedbackRepository = feedback;
    }

    public IActionResult Index()
    {
        var viewModel = new HomeViewModel() 
        {
            PizzaList = _pizzaRepository.GetAllPizzas().ToList(),
            FeedbackList = _feedbackRepository.GetAllFeedbacks().ToList()
        };

        // var pizzaList = _pizzaRepository.GetAllPizzas();
        return View(viewModel);
    }

    [Route("blog/{year:int}/{month:int}/{day:int}")]
    public ActionResult GetPost(int year, int month, int day) 
    {
        return Content($"post on {year}-{month}-{day}");
    }

    public IActionResult Privacy()
    {
        try 
        {
            //throw new Exception("fake error");
            return View();
        } 
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            return RedirectToAction("Error");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // https://localhost:{port}/home/{id}
    public IActionResult Detail(int id) 
    {
        return View(_pizzaRepository.GetPizzaById(id));
    }
}
