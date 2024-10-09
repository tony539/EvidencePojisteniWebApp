using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EvidencePojisteniWebApp.Models

namespace EvidencePojisteniWebApp.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;

		public AccountController
		(
			UserManager<IdentityUser> userManager,
			SignInManager<IdentityUser> signInManager
		)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		private IActionResult RedirectToLocal(string? returnUrl)
		{
			if(Url.IsLocalUrl(returnUrl))
				return Redirect(returnUrl);
			else
				return RedirectToAction(nameof(HomeController.Index), "Home");
		}

		public IActionResult Login(string? returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;

			if (ModelState.IsValid)
			{
				Microsoft.AspNetCore.Identity.SignInResult result =
					await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
				
				if (result.Succeeded)
					return RedirectToLocal(returnUrl);

				ModelState.AddModelError("Login error", "Neplatné přihlašovací údaje.");
				return View(model);
			}
			// Pokud byly neplatné přihlašovací údaje, vrátíme uživatele k přihlašovacímu formuláři
			return View(model);
		}
	}
}
