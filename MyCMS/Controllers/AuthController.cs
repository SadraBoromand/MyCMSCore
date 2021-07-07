using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.ViewModels.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MyCMS.Controllers
{
    public class AuthController : Controller
    {
        private IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            var user = _userRepository.Register(register);

            if (user == false)
            {
                ModelState.AddModelError("Email", "کاربر وجود دارد");
                return View(register);
            }

            return View("_SuccessRegister", register);
        }

        #endregion

        #region Login
        //[Route("Login/{ReturnUrl?}")]
        public IActionResult Login(string ReturnUrl = "/")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        //[Route("Login/{ReturnUrl?}")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string ReturnUrl = "/")
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userRepository.Login(login);

            if (user == null)
            {
                ModelState.AddModelError("Email", "اطلاعات صحیح نیست");
                return View(login);
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                new Claim(ClaimTypes.Name,user.Email),
                new Claim(ClaimTypes.Role,user.Role.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principle = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties()
            {
                IsPersistent = login.RemmberMe
            };

            await HttpContext.SignInAsync(principle, properties);

            return Redirect(ReturnUrl);
        }

        #endregion

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
    }
}
