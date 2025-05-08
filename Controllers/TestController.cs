using Microsoft.AspNetCore.Mvc;

namespace PizzaKing.Controllers;

[Controller]
[Route("[controller]")]
public class TestController : Controller
{
    [Route("~/try/{parameter=參數一}")]
    [Route("try/{parameter=參數一}/{parameter2}/{parameter3:int}")]
    [Route("try/{parameter=para1}")]
    [Route("try/{parameter=para1}/{parameter2}")]
    public ActionResult Try(string parameter, string parameter2, int parameter3) 
    {
        return Content($"Hello World {parameter}, {parameter2}, {parameter3}");
        // return View();
    }

    [Route("DoNothing")]
    public EmptyResult DoNothing()
    {
        return new EmptyResult();
    }

    [Route("ToBaidu")]
    public RedirectResult ToBaidu() 
    {
        return Redirect("http://www.baidu.com");
    }

    [Route("ToTry")]
    public RedirectToActionResult ToTry() 
    {
        return RedirectToAction("Try", "Test");
    }

    [Route("GetJson")]
    public JsonResult GetJson() 
    {
        var data = new { Name="Test", Age="108" };
        return Json(data);
    }

    [Route("GetContent")]
    public ContentResult GetContent() 
    {
        return Content("Hello world");
    }

    [Route("Status")]
    public StatusCodeResult Status()
    {
        // return Ok(); //200ok
        // return NoContent(); // 201
        // return NotFound(); // 404
        // return BadRequest(); // 400
        // return Forbid(); //403
        // return StatusCode(500);// 500 
        return StatusCode(400);// 400 
    }

    [Route("DownloadFile")]
    public FileResult DownloadFile(string filename) 
    {
        string root = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(root, "Files", filename);
        // filePath = root + "/" + "Files" + "/" + filename
        // - mac: /Users/alex/Desktop/code/ch4/4-3/Files/HelloWorld.txt
        // - win: C:\Documents and Settings\USER\桌面\HelloWorld.txt

        byte[] fileByte = System.IO.File.ReadAllBytes(filePath);
        
        return File(fileByte, "application/txt", "download.txt");
    }

    [HttpPost("GenerateLargeFile")]
    public ActionResult GenerateLargeFile(long sizeInGb, string outputFileName)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "Files", outputFileName);
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            using var writer = new StreamWriter(fileStream);
            // Generate a large file by writing a large amount of data
            for (long i = 0; i < sizeInGb * 1024 * 1024 * 1024 / 11; i++) // Adjust the loop to write more data
            {
                writer.Write("hello world"); // Writing "hello world" repeatedly
            }
            writer.Flush();
        }
        return NoContent();
    }

    [Route("DownloadLargeFile")]
    public FileStreamResult DownloadLargeFile(string filename) 
    {
        string root = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(root, "Files", filename);

        FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        return new FileStreamResult(stream, "applicaton/txt")
        {
            FileDownloadName = "download.txt"
        };
    }
}