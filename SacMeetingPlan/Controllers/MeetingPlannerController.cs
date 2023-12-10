using Microsoft.AspNetCore.Mvc;


namespace SacMeetingPlan.Controllers;

public class MeetingPlannerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Speakers(string name, int numTimes = 1) 
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
