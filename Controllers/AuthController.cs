using Microsoft.AspNetCore.Mvc;
using MedicalApp.Services;

namespace MedicalApp.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@test.com" && password == "1234")
            {
                var tokenService = new TokenService();
                var token = tokenService.GenerateToken(email);

                HttpContext.Session.SetString("JWToken", token);

                return RedirectToAction("Create", "Patient");
            }

            ViewBag.Error = "Invalid Login";
            return View();
        }
    }
}
