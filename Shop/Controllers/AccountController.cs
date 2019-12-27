using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Shop.Data.Models;

namespace CustomIdentityApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;

        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Users user = new Users { Email = model.Email, UserName = model.Email, Year=model.Year};
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
<<<<<<< Updated upstream
                    // установка куки
                    await _signInManager.PasswordSignInAsync(user.Email, user.PasswordHash, false, false);
=======
                    // установка куки                    
                    await _signInManager.SignInAsync(user, false);
>>>>>>> Stashed changes
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}