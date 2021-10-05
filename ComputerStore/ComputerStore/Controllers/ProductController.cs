using BLL_ComputerStore.Infrastucture.Models;
using BLL_ComputerStore.Services;
using ComputerStore.Models;
using Domain_ComputerStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI_ComputerStore.Models;

namespace ComputerStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IStoreService _storeService;
        private readonly UserManager<User> _userManager;

        public ProductController(ILogger<ProductController> logger, IStoreService storeService, UserManager<User> userManager)
        {
            _logger = logger;
            _storeService = storeService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() =>
            await Task.Run(() => View());

        public async Task<IActionResult> GetProducts(string category)
        {
            var products = await _storeService.GetProductFromCategoryAsync(category);

            await AddTestProducts(); // test method

            return PartialView("ProductCards", products);
        }

        public async Task<IActionResult> GetReviews(int productId)
        {
            var reviews = await _storeService.GetGroupReviewByProductIdAsync(productId);
            if(reviews != null)
            {
                foreach (var review in reviews.Reviews)
                {
                    var user = await _userManager.FindByIdAsync(review.UserId.ToString());
                    review.UserName = user.UserName;
                }
            }
            else
                return PartialView("Reviews");

            return PartialView("Reviews", reviews);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Catalog(string category)
        {
            ViewBag.Category = category;
            return await Task.Run(() => View("Catalog"));
        }

        public async Task<IActionResult> GetSelectProducts(string category, int minPrice, int maxPrice, List<string> values)
        {
            var selectedProducts = await _storeService.GetSelectProductsAsync(minPrice, maxPrice, values, category);
            ViewBag.Category = category;
            ViewBag.Filter = true;
            return View("Catalog", selectedProducts);
        }

        public async Task<IActionResult> Product(int id)
        {
            ProductDTO product = await _storeService.GetProductByIdAsync(id);
            product.Properties = await _storeService.GetProductValuesAsync(id);
            return View(product);
        }

        public async Task<IActionResult> GetProductDiscount(int productId)
        {
            return await Task.Run(() => PartialView(""));
        }

        public async Task AddComment(ReviewViewModel model)
        {
            if(TryValidateModel(model))
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                var review = new ReviewDTO()
                {
                    CostRate = model.CostRate,
                    QualityRate = model.QualityRate,
                    FuncRate = model.FuncRate,
                    Pros = model.Pros,
                    Cons = model.Cons,
                    Comment = model.Comment,
                    IsRecommend = Convert.ToBoolean(model.isRecommend),
                    ProductId = model.ProductId,
                    UserId = user.Id,
                };


                await _storeService.AddReviewAsync(review);
                TempData["Success"] = "Thanks for your riview";
            }
            TempData["Error"] = "Incorrect data in your review";
        }

        private async Task AddTestProducts() // test method
        {
            var products = await _storeService.GetProductsAsync();
            if (products.Count() == 0)
                _storeService.AddTestPorducts();
        }
    }
}
