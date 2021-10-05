using AutoMapper;
using BLL_ComputerStore.Infrastucture.Models;
using Core_ComputerStore.Context;
using Domain_ComputerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL_ComputerStore.Services
{

    public interface IStoreService
    {
        void AddTestPorducts(); //test method
        Task AddReviewAsync(ReviewDTO review);
        Task<GroupReviewDTO> GetGroupReviewByProductIdAsync(int productid);
        Task<List<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<List<PropertyDTO>> GetProductValuesAsync(int id);
        Task<List<ProductDTO>> GetProductFromCategoryAsync(string category);
        Task<List<ProductDTO>> GetSelectProductsAsync(int maxPrice, int minPrice, List<string> values, string category);
    }

    public class StoreService : IStoreService
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;

        public StoreService(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddReviewAsync(ReviewDTO review)
        {
            var group = _context.GroupsReview.First(x => x.ProductId == review.ProductId);
            review.GroupReviewId = group.Id;
            review.WriteTime = DateTime.Now;
            review.AvgRate = CalcArrAvg(new float[] { review.CostRate, review.QualityRate, review.FuncRate });
            group.Reviews.Add(_mapper.Map<Review>(review));
            SetAvgProductRate(review.ProductId, _context.GroupsReview.Include(x => x.Reviews).First(x => x.Id == group.Id));

            await _context.SaveChangesAsync();
        }

        public async Task<GroupReviewDTO> GetGroupReviewByProductIdAsync(int id)
        {
            if (_context.Reviews.ToList().Count() != 0)
                return _mapper.Map<GroupReviewDTO>(await _context.GroupsReview.FirstAsync(x => x.ProductId == id));
            return null;
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id) =>
                await Task.Run(() => _mapper.Map<ProductDTO>(_context.Products.FirstOrDefault(x => x.Id == id)));
        public async Task<List<PropertyDTO>> GetProductValuesAsync(int id) =>
            await Task.Run(() => _mapper.Map<List<PropertyDTO>>(_context.Properties.Where(x => x.ProductId == id)));

        public async Task<List<ProductDTO>> GetProductsAsync()
        {
            var products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<List<ProductDTO>> GetProductFromCategoryAsync(string category)
        {
            var products = await _context.Products.Where(x => x.Category == category).ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<List<ProductDTO>> GetSelectProductsAsync(int minPrice, int maxPrice, List<string> values, string category)
        {
            var products = await _context.Products.Include(x => x.Properties).Where(x => x.Category == category).ToListAsync();
            var selectedProducts = products.Where(x => x.Cost >= minPrice && x.Cost <= maxPrice).ToList();

            var properties = new List<KeyValuePair<string, string>>();

            foreach (var property in values)
            {
                properties.Add(new KeyValuePair<string, string>(property.Split()[0], property.Split().Last()));
            }

            selectedProducts = SelectByFilter(selectedProducts, ConvertPropertyListToDictionary(properties));

            return _mapper.Map<List<ProductDTO>>(selectedProducts.ToList());
        }
        private void SetAvgProductRate(int productId, GroupReview group)
        {
            List<float> avgList = new List<float>();
            var product = _context.Products.First(x => x.Id == productId);
            foreach (var review in group.Reviews)
            {
                avgList.Add(review.AvgRate);
            }
            product.Rate = CalcArrAvg(avgList.ToArray());
            _context.SaveChanges();
        }
        private float CalcArrAvg(float[] arr) =>
            (float)(arr.Average());
        private List<Product> SelectByFilter(List<Product> products, Dictionary<string, List<string>> filterProperties)
        {
            foreach (var product in products.ToList())
            {
                if (product.Properties.Count == 0)
                    products.Remove(product);
                else
                {
                    var isValid = IsValidProduct(product, filterProperties);

                    if (isValid == false)
                        products.Remove(product);
                }
            }
            return products;
        }

        private bool IsValidProduct(Product product, Dictionary<string, List<string>> filterProperties)
        {
            bool isValid = false;

            foreach (var filterProp in filterProperties)
            {
                isValid = false;
                foreach (var propertyValue in filterProp.Value)
                {
                    foreach (var productProp in product.Properties)
                    {
                        if (filterProp.Key == productProp.Key && propertyValue == productProp.Value)
                            isValid = true;
                    }
                }
                if (!isValid)
                    return isValid;
            }
            return true;
        }

        private Dictionary<string, List<string>> ConvertPropertyListToDictionary(List<KeyValuePair<string, string>> properties)
        {
            var dictionary = new Dictionary<string, List<string>>();
            var values = new List<string>();
            string tempKey = null;

            foreach (var property in properties)
            {
                if (tempKey == null)
                {
                    tempKey = property.Key;
                    values.Add(property.Value);
                    dictionary.Add(property.Key, values);
                }
                else if (tempKey == property.Key)
                    values.Add(property.Value);
                else
                {
                    tempKey = property.Key;
                    values = new List<string>();
                    values.Add(property.Value);
                    dictionary.Add(property.Key, values);
                }
            }

            return dictionary;
        }

        // test methods
        #region Test Methods
        public void AddTestPorducts()
        {
            AddCPUs();
            AddGPUs();
            _context.SaveChanges();
        }
        private void AddCPUs()
        {
            int productId = 0;

            productId = AddTestProduct("Intel Core i3 10100F", "3.60hz; 4 core; 8 threads; cash 6 MB", 2730,
                "https://content.rozetka.com.ua/goods/images/big/37318214.jpg", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Intel"); // Manufacturer
            AddTestProp(productId, "Core", "4"); // Core
            AddTestProp(productId, "Thread", "8"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics

            productId = AddTestProduct("Ryzen 5 3600", "3.60hz; 6 core; 12 threads; cash 32 MB", 5619,
                "https://img.telemart.ua/264933-528644/amd-ryzen-5-3600-3642ghz-32mb-sam4-tray-100-000000031.png", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "AMD"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "12"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics

            productId = AddTestProduct("Ryzen 5 1600", "3.20hz; 6 core; 12 threads; cash 16 MB", 3350,
                "https://img.telemart.ua/181596-441299/amd-ryzen-5-1600-3236ghz-sam4-box-yd1600bbafbox.png", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "AMD"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "12"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics

            productId = AddTestProduct("Intel Core i5 9400F", "2.90hz; 6 core; 6 threads; cash 9 MB", 5445,
                "https://content.rozetka.com.ua/goods/images/big/13585196.jpg", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Intel"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "6"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics
        }
        private void AddGPUs()
        {
            int productId = 0;

            productId = AddTestProduct("RX 580", "8GB 256BIT Core frequency 1360", 15805,
                "https://content2.rozetka.com.ua/goods/images/big/190384635.jpg", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "8"); // Memory
            AddTestProp(productId, "Bitness", "256"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR5"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "2"); // Fan
        }
        private int AddTestProduct(string name, string description, int cost, string productImage, string category)
        {
            _context.Products.Add(new Product() { Name = name, Description = description, Cost = cost, ProductImage = productImage, Category = category });
            _context.SaveChanges();
            return _context.Products.FirstOrDefault(x => x.Name == name).Id;
        }
        private void AddTestProp(int id, string key, string value)
        {
            _context.Properties.Add(new Property() { ProductId = id, Key = key, Value = value });
        }
        private void AddTestGropReview(int id)
        {
            _context.GroupsReview.Add(new GroupReview() { ProductId = id });
        }
        #endregion
    }
}
