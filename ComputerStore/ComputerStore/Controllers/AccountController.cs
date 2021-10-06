using BLL_ComputerStore.Infrastucture;
using Domain_ComputerStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using UI_ComputerStore.Models;
using System.Linq;
using BLL_ComputerStore.Services;
using BLL_ComputerStore.Infrastucture.Models;
using System.Collections.Generic;

namespace UI_ComputerStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailService _mailService;
        private readonly IUserService _userService;

        public AccountController(UserManager<User> userManager, RoleManager<Role> roleManager, SignInManager<User> signInManager, IMailService mailService, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _mailService = mailService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!TryValidateModel(model))
            {
                return View();
            }

            var user = new User()
            {
                Email = model.Email,
                UserName = model.Login,
                Name = model.Name,
                Surname = model.Surname,
                Patronymic = model.Patronymic,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                string messages = "";
                foreach (var error in result.Errors)
                {
                    messages += error.Description + Environment.NewLine;
                }
                TempData["Error"] = $"{messages}";
                return Redirect("~/Account/Register");
            }

            #region SendGridEmail

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var link = Url.Action("ConfirmEmail", "Account",
                new { token = token, userId = user.Id }, Request.Scheme, Request.Host.Value);

            await _mailService.SendGridEmail(model.Email, "Confirm email", $"<h1>Hello, {model.Email}</h1>" +
                $"<h4>Please, confirm your email: <a href='{link}'>Confirm</a></h4>");

            #endregion

            if (await _roleManager.FindByNameAsync("user") == null)
            {
                await _roleManager.CreateAsync(new Role() { Name = "user" });
                await _userManager.AddToRoleAsync(user, "user");
            }
            else
                await _userManager.AddToRoleAsync(user, "user");

            TempData["Success"] = $"We just need one small favor from you - please confirm your email: {user.Email} to continue using Computer Store";
            return Redirect("~/Product/Index");
        }

        [HttpGet]
        public IActionResult LogIn() => View();

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (!TryValidateModel(model))
            {
                return View();
            }

            var user = await _userManager.FindByNameAsync(model.Login);
            if (user != null)
            {
                if (user.EmailConfirmed)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Product");
                    }
                    else
                    {
                        TempData["Error"] = "Incorrect login or password";
                        return View();
                    }
                }
                else
                {
                    TempData["Error"] = $"You need to confirm your email: {user.Email} to Sign In";
                    return View();
                }
            }

            TempData["Error"] = "Incorrect login or password";
            return View();
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return NotFound();

            var user = await _userManager.FindByIdAsync(userId: userId);
            if (user == null)
                return StatusCode(500);

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                TempData["Success"] = "Email confirmed successfully";
                return RedirectToAction("LogIn", "Account");
            }
            else
            {
                TempData["Error"] = "Email confirmation error";
                return RedirectToAction("Index", "Product");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Product");
        }

        public async Task<IActionResult> Manage(string tab)
        {
            return await Task.Run(() => View("Manage", tab));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword() => await Task.Run(() => PartialView("СhangePassword"));
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (TryValidateModel(model))
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "Success change password";
                        return RedirectToAction("Logout", "Account");
                    }
                    else
                    {
                        TempData["Error"] = "The old or new password is incorrect";
                        return View("Manage");
                    }
                }
            }

            TempData["Error"] = "Incorrect password";
            return View("Manage");
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> PersonalData()
        {
            Domain_ComputerStore.Models.User user = await _userManager.FindByNameAsync(User.Identity.Name);
            return await Task.Run(() => PartialView("PersonalData", user));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> UpBalance()
            => await Task.Run(() => PartialView("UpBalance"));

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpBalance(UpBalanceViewModel model)
        {
            if (TryValidateModel(model))
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                await _userService.PutMoneyForUserAsync(model.Amount, user);
                await _userManager.UpdateAsync(user);
                TempData["Success"] = "Money has been added to your balance";
                return View("Manage");
            }

            TempData["Error"] = GetValidateErrors();
            return View("Manage");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GetUserMoney(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                return PartialView("UserMoney", user.Money.ToString());
            }
            return PartialView("UserMoney");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GetCountProducts(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null && user.BasketId != 0)
            {
                var basket = await _userService.GetBasketByIdAsync(user.BasketId);
                return PartialView("Basket", basket.Products.Count());
            }
            return PartialView("Basket");
        }

        [Authorize]
        public async Task AddToBasket(int productId, string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                await _userService.AddProductToBasketAsync(productId, user);
                await _userManager.UpdateAsync(user);
            }
            else
            {
                TempData["Error"] = "You need to log in to add a product to the cart";
            }
        }

        [Authorize]
        public async Task<IActionResult> Order()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var orders = new List<OrderDTO>();
            if(user != null)
            {
                orders = await _userService.GetOrdersAsync(user);
            }
            
            return await Task.Run(() => PartialView("Order", orders));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GetOrderProducts(int orderId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var products = new List<ProductDTO>();
            products = await _userService.GetProductsFromOrderAsync(orderId);

            TempData["OrderId"] = orderId;
            return await Task.Run(() => PartialView("ProductsOrder", products));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Checkout(List<int> productId, List<int> count)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < productId.Count; i++)
            {
                dictionary.Add(productId[i], count[i]);
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            bool result = false;
            if (user != null)
            {
                result = await _userService.CheckoutAsync(dictionary, user);

                if (result)
                {
                    await _userManager.UpdateAsync(user);
                    TempData["Success"] = "The order has been placed!";
                }
                else
                    TempData["Error"] = "Not enough money in the account";
            }
            return View("Manage", "Basket");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RemoveProductFromBasket(int productId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            await _userService.RemoveProductFromBasketAsync(productId, user.BasketId);
            return View("Manage", "Basket");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Basket()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var products = new List<ProductDTO>();
            if (user != null)
            {
                products = await _userService.GetProductFromBasket(user);
            }

            return PartialView("Basket", products);
        }

        private string GetValidateErrors()
        {
            string textError = "";
            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    textError += error.ErrorMessage.ToString() + Environment.NewLine;
                }
            }
            return textError;
        }
    }
}
