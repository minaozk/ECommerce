using IconEtic.Business.ControllerHandler;
using IconEtic.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IconEtic.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationControllerHandler _authenticationControllerHandler;

        public AuthenticationController(IAuthenticationControllerHandler authenticationControllerHandler)
        {
            _authenticationControllerHandler = authenticationControllerHandler;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                _authenticationControllerHandler.UserLogin(model.Email, model.Password, Response);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
            
        }

        public IActionResult Exit()
        {
            bool result = _authenticationControllerHandler.Exit(Request);
            if (result == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
            return View();
        }
    }
}
