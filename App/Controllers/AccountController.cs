#nullable disable

using App.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Identity.Core;
using App.Data;
using System.Diagnostics;

namespace App.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<Driver> _userManager;
    private readonly SignInManager<Driver> _signInManager;
    private readonly IRepository _repository;


    //  private User<TUser> _user;

    public AccountController(UserManager<Driver> userManager, SignInManager<Driver> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    //   public IActionResult Index(uint? id)
    public IActionResult Index()
    {
        // if (httpContext.User.Identity.IsAuthenticated) {
        //     var id = httpContext.User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
        // }  else{
        //    Guid.Empty.ToString();
        // } 
        // var id = _userManager.GetUserId(ClaimsPrincipal);
        // return View(await _repository.GetBy<Driver>(m => m.Id == id).FirstOrDefault());
        // var id = User.Identity.GetUserId();
        return View();
    }

    #region Register
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(Models.ViewModels.Account.RegistrationModel userModel)
    {
        if (!ModelState.IsValid)
        {
            return View(userModel);
        }

        Driver user = new Driver();
        user.FirstName = userModel.FirstName;
        user.LastName = userModel.LastName;
        user.BirthDate = userModel.BirthDate;
        user.UserName = userModel.Email;
        user.Email = userModel.Email;

        IdentityResult result = await _userManager.CreateAsync(user, userModel.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.TryAddModelError(error.Code, error.Description);
            }
            return View(userModel);
        }

        return RedirectToAction(nameof(HomeController.Index), "Home");
    }
    #endregion

    #region Login
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string returnUrl)
    {
        ViewData["ReturnUrl"] = returnUrl;
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(Models.ViewModels.Account.LoginModel userModel, string returnUrl)
    {
        if (!ModelState.IsValid)
        {
            return View(userModel);
        }

        var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, lockoutOnFailure: true);
        if (result.Succeeded)
        {
            return RedirectToLocal(returnUrl);
        }
        else
        {
            ModelState.AddModelError("", "Email Invalide ou le Mot de Passe");
            return View();
        }
    }
    #endregion

    #region Logout
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction(nameof(HomeController.Index), "Home");
    }
    #endregion

    private IActionResult RedirectToLocal(string returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
            return Redirect(returnUrl);
        else
            return RedirectToAction(nameof(HomeController.Index), "Home");
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Error()
    {
        return View();
    }
}
