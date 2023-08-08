using Microsoft.AspNetCore.Mvc;

namespace IntroToMVCW23.Controllers
{
    public class GreetingController: Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Goodbye()
        {
            ViewData["Repetitions"] = 2;
            return View();
        }

        // parameter binding
        // string reps = "dog"

        public IActionResult GoodbyeFromSomewhereElse(int reps)
        {
            ViewData["Repetitions"] = reps;
            return View("Goodbye");
        }
    }
}
