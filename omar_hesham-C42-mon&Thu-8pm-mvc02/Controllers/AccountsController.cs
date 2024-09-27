using Microsoft.AspNetCore.Mvc;

namespace omar_hesham_C42_mon_Thu_8pm_mvc02.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
