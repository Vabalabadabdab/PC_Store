using AutoMapper;
using BLL_ComputerStore.Infrastucture.Models;
using Core_ComputerStore.Context;
using Domain_ComputerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ComputerStore.Services
{
    public interface IUserService
    {
        Task PutMoneyForUserAsync(decimal money, User user);
        Task AddProductToBasketAsync(int productId, User user);
        Task RemoveProductFromBasketAsync(int productId, int basketId);
        Task<Basket> GetBasketByIdAsync(int basketId);
        Task<List<ProductDTO>> GetProductFromBasket(User user);
        Task<bool> CheckoutAsync(Dictionary<int, int> productIdCount, User user);
        Task<List<OrderDTO>> GetOrdersAsync(User user);
        Task<List<ProductDTO>> GetProductsFromOrderAsync(int orderId);
    }

    public class UserService : IUserService
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public UserService(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CheckoutAsync(Dictionary<int, int> productId_count, User user)
        {
            decimal totalSum = 0;
            var products = new List<Product>();
            foreach (var item in productId_count)
            {
                var product = await _context.Products.FindAsync(item.Key);
                totalSum += (decimal)product.Cost * item.Value;
                products.Add(product);
            }

            if (user.Money < totalSum)
                return false;

            user.Orders.Add(new Order() { Products = products, Status = "In progress", TotalSum = totalSum });
            user.Money -= totalSum;
            await ClearBasketAsync(user.BasketId);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<OrderDTO>> GetOrdersAsync(User user)
        {
            var orders = new List<Order>();
            foreach (var userOrder in _context.Users.Include(x => x.Orders))
            {
                if (user.Id == userOrder.Id)
                {
                    orders = userOrder.Orders.ToList();
                    break;
                }
            }

            return await Task.Run(() => _mapper.Map<List<OrderDTO>>(orders));
        }
        public async Task<List<ProductDTO>> GetProductsFromOrderAsync(int orderId)
        {
            var products = new List<Product>();
            foreach (var order in _context.Orders.Include(x => x.Products))
            {
                if(order.Id == orderId)
                {
                    products = order.Products.ToList();
                    break;
                }
            }

            return await Task.Run(() => _mapper.Map<List<ProductDTO>>(products));
        }

        public async Task PutMoneyForUserAsync(decimal money, User user) =>
            await Task.Run(() => user.Money += money);
        public async Task RemoveProductFromBasketAsync(int productId, int basketId)
        {
            var product = await _context.Products.FindAsync(productId);
            foreach (var basket in _context.Baskets.Include(x => x.Products))
            {
                if (basket.Id == basketId)
                {
                    basket.Products.Remove(product);
                }
            }

            await _context.SaveChangesAsync();
        }
        public async Task AddProductToBasketAsync(int productId, User user)
        {
            if (user.BasketId == 0)
            {
                var basket = await CreateBasketAsync(productId);
                user.BasketId = basket.Id;
                var product = _context.Products.First(x => x.Id == productId);
                basket.Products.Add(product);
            }
            else
            {
                var basket = await GetBasketByIdAsync(user.BasketId);
                if (basket != null)
                {
                    var product = _context.Products.First(x => x.Id == productId);

                    basket.Products.Add(product);
                }
            }
            await _context.SaveChangesAsync();
        }
        public async Task<List<ProductDTO>> GetProductFromBasket(User user)
        {
            var products = new List<Product>();
            foreach (var basket in _context.Baskets.Include(x => x.Products))
            {
                if (basket.Id == user.BasketId)
                {
                    foreach (var product in basket.Products)
                    {
                        products.Add(product);
                    }
                }
            }
            return await Task.Run(() => _mapper.Map<List<ProductDTO>>(products));
        }
        private async Task ClearBasketAsync(int basketId)
        {
            foreach (var basket in _context.Baskets.Include(x => x.Products))
            {
                if(basket.Id == basketId)
                {
                    await Task.Run(() => basket.Products = new List<Product>());
                }
            }
        }
        private async Task<Basket> CreateBasketAsync(int productId)
        {
            var basket = new Basket();
            _context.Add(basket);
            await _context.SaveChangesAsync();
            return basket;
        }
        public async Task<Basket> GetBasketByIdAsync(int basketId)
            => await Task.Run(() => _context.Baskets.FirstOrDefault(x => x.Id == basketId));

    }
}
