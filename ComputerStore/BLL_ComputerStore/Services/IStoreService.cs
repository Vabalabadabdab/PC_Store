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
            AddMotherboards();
            AddMouses();
            AddKeyboards();
            AddLaptops();
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
            AddTestProp(productId, "Frequency", "3.60GHz"); // Frequency

            productId = AddTestProduct("Ryzen 5 3600", "3.60hz; 6 core; 12 threads; cash 32 MB", 5619,
                "https://img.telemart.ua/264933-528644/amd-ryzen-5-3600-3642ghz-32mb-sam4-tray-100-000000031.png", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "AMD"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "12"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics
            AddTestProp(productId, "Frequency", "3.60GHz"); // Frequency

            productId = AddTestProduct("Ryzen 5 1600", "3.20hz; 6 core; 12 threads; cash 16 MB", 3350,
                "https://img.telemart.ua/181596-441299/amd-ryzen-5-1600-3236ghz-sam4-box-yd1600bbafbox.png", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "AMD"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "12"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics
            AddTestProp(productId, "Frequency", "3.20GHz"); // Frequency

            productId = AddTestProduct("Intel Core i5 9400F", "2.90hz; 6 core; 6 threads; cash 9 MB", 5445,
                "https://content.rozetka.com.ua/goods/images/big/13585196.jpg", "CPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Intel"); // Manufacturer
            AddTestProp(productId, "Core", "6"); // Core
            AddTestProp(productId, "Thread", "6"); // Thread
            AddTestProp(productId, "IntegratedGraphics", "No"); // Integrated Graphics
            AddTestProp(productId, "Frequency", "2,90GHz"); // Frequency
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

            productId = AddTestProduct("MSI GeForce RTX 3060 Ti GAMING Z TRIO", "8GB 256BIT", 32499,
                "https://img.telemart.ua/369448-514664/msi-geforce-rtx-3060-ti-gaming-z-trio-8192mb-rtx-3060-ti-gaming-z-trio-lhr.png", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Nvidia"); // Manufacturer
            AddTestProp(productId, "Memory", "8"); // Memory
            AddTestProp(productId, "Bitness", "256"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR6"); // MemoryType
            AddTestProp(productId, "Backlight", "RGB"); // Backlight
            AddTestProp(productId, "Fan", "3"); // Fan

            productId = AddTestProduct("Sapphire Radeon RX 6600 XT PULSE", "8GB 128BIT Core frequency 2589", 25499,
                "https://img.telemart.ua/377535-526446/sapphire-radeon-rx-6600-xt-pulse-8192mb-11309-03-20g.jpg", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "8"); // Memory
            AddTestProp(productId, "Bitness", "256"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR6"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "2"); // Fan

            productId = AddTestProduct("Palit GeForce GT 1030", "2GB 64BIT Core frequency 1151", 2976,
                "https://img.telemart.ua/86463-367353/palit-geforce-gt-1030-2048mb-nec103000646-1082f.jpg", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "8"); // Memory
            AddTestProp(productId, "Bitness", "256"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR4"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "No"); // Fan

            productId = AddTestProduct("MSI GeForce GTX 1650 VENTUS XS OC 4096MB", "4GB 128BIT Core frequency 1740", 2976,
                "https://img.telemart.ua/123791-446790/msi-geforce-gtx-1650-ventus-xs-oc-4096mb-gtx-1650-ventus-xs-4g-oc.png", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Nvidia"); // Manufacturer
            AddTestProp(productId, "Memory", "4"); // Memory
            AddTestProp(productId, "Bitness", "128"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR5"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "2"); // Fan

            productId = AddTestProduct("MSI GeForce GT 730", "2GB 64BIT Core frequency 902", 2099,
                "https://img.telemart.ua/46573-484606/msi-geforce-gt-730-2048mb-n730k-2gd3hlp.png", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "4"); // Memory
            AddTestProp(productId, "Bitness", "64"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR3"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "No"); // Fan

            productId = AddTestProduct("Sapphire Radeon E9260 Pro", "4GB 128BIT Core frequency 2150", 2099,
                "https://img.telemart.ua/355838-500354/sapphire-radeon-e9260-pro-4096mb-11269-99-90g-fr-factory-recertified.png", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "4"); // Memory
            AddTestProp(productId, "Bitness", "128"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR5"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "1"); // Fan

            productId = AddTestProduct("Gigabyte GeForce RTX 2070 SUPER WindForce", "8GB 256BIT Core frequency 1785", 26554,
                "https://img.telemart.ua/186245-382335/gigabyte-geforce-rtx-2070-super-windforce-oc-3x-8192mb-gv-n207swf3oc-8gd.png", "GPU");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Amd"); // Manufacturer
            AddTestProp(productId, "Memory", "8"); // Memory
            AddTestProp(productId, "Bitness", "256"); // Bitness
            AddTestProp(productId, "MemoryType", "GDDR6"); // MemoryType
            AddTestProp(productId, "Backlight", "No"); // Backlight
            AddTestProp(productId, "Fan", "3"); // Fan
        }
        private void AddMotherboards()
        {
            int productId = 0;

            productId = AddTestProduct("MSI B450 GAMING PLUS MAX", "AM4 ATX", 2849,
                "https://img.telemart.ua/170156-450049/msi-b450-gaming-plus-max-sam4-amd-b450.png", "Motherboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "MSI"); // Manufacturer
            AddTestProp(productId, "Socket", "AM4"); // Socket
            AddTestProp(productId, "FormFactor", "ATX"); // Bitness
            AddTestProp(productId, "MemorySlots", "4"); // MemoryType
            AddTestProp(productId, "SATA", "6"); // Backlight
            AddTestProp(productId, "Backlight", "No"); // Fan

            productId = AddTestProduct("MSI B550M PRO-VDH WIFI", "AM4 microATX", 2849,
                "https://img.telemart.ua/286212-517978/msi-b550m-pro-vdh-wifi-sam4-amd-b550.png", "Motherboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "MSI"); // Manufacturer
            AddTestProp(productId, "Socket", "AM4"); // Socket
            AddTestProp(productId, "FormFactor", "microATX"); // Bitness
            AddTestProp(productId, "MemorySlots", "4"); // MemoryType
            AddTestProp(productId, "SATA", "4"); // Backlight
            AddTestProp(productId, "Backlight", "No"); // Fan

            productId = AddTestProduct("Gigabyte H310M S2", "LGA1151-V2 microATX", 1149,
                "https://img.telemart.ua/83296-276046/gigabyte-h310m-s2-s1151-v2-intel-h310.png", "Motherboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Gigabyte"); // Manufacturer
            AddTestProp(productId, "Socket", "1151-V2"); // Socket
            AddTestProp(productId, "FormFactor", "microATX"); // Bitness
            AddTestProp(productId, "MemorySlots", "2"); // MemoryType
            AddTestProp(productId, "SATA", "4"); // Backlight
            AddTestProp(productId, "Backlight", "No"); // Fan

            productId = AddTestProduct("Asus TUF B450M-PRO GAMING", "AM4 DDR4 microATX", 2399,
                "https://img.telemart.ua/270184-486939/asus-tuf-gaming-b550m-plus-sam4-amd-b550.png", "Motherboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Asus"); // Manufacturer
            AddTestProp(productId, "Socket", "AM4"); // Socket
            AddTestProp(productId, "FormFactor", "microATX"); // Bitness
            AddTestProp(productId, "MemorySlots", "4"); // MemoryType
            AddTestProp(productId, "SATA", "6"); // Backlight
            AddTestProp(productId, "Backlight", "Yes"); // Fan
        }
        private void AddMouses()
        {
            int productId = 0;

            productId = AddTestProduct("Logitech G Pro X SUPERLIGHT", "WHITE 100-25400 dpi", 4999,
                "https://img.telemart.ua/343952-511357/logitech-g-pro-x-superlight-910-005942-white.png", "Mouse");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Logitech"); // Manufacturer
            AddTestProp(productId, "Sensor", "Optical"); // Sensor
            AddTestProp(productId, "Connect", "Wireless"); // Connect
            AddTestProp(productId, "Color", "White"); // Color
            AddTestProp(productId, "Dpi", "100–25400 dpi"); // DPI
        }
        private void AddKeyboards()
        {
            int productId = 0;

            productId = AddTestProduct("HATOR Rockfall Outemu Mechanical Switches Red RU (HTK-606)", "Mechanical Wired RGB Backlight", 1799,
                "https://img.telemart.ua/91294-475464/hator-rockfall-outemu-mechanical-switches-red-ru-htk-606-black.png", "Keyboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "-"); // Manufacturer
            AddTestProp(productId, "Type", "Mechanical"); // Type
            AddTestProp(productId, "FormFactor", "Full"); // Form factor
            AddTestProp(productId, "Connect", "Wired"); // Connect
            AddTestProp(productId, "Backlight", "RGB"); // Backlight

            productId = AddTestProduct("Logitech G213 Prodigy", "Membrane Wired RGB Backlight", 1899,
                "https://img.telemart.ua/60840-528830/logitech-g213-prodigy-920-008092-black.png", "Keyboard");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Logitech"); // Manufacturer
            AddTestProp(productId, "Type", "Membrane"); // Type
            AddTestProp(productId, "FormFactor", "Full"); // Form factor
            AddTestProp(productId, "Connect", "Wired"); // Connect
            AddTestProp(productId, "Backlight", "RGB"); // Backlight
        }
        private void AddLaptops()
        {
            int productId = 0;

            productId = AddTestProduct("Asus ZenBook S UX393EA-HK022R (90NB0S71-M01230) Jade Black", "Core i7 4 Core RAM 16Gb 1024 SSD", 53999,
                "https://img.telemart.ua/355859-499836/asus-zenbook-s-ux393ea-hk022r-90nb0s71-m01230-jade-black.png", "Laptop");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Asus"); // Manufacturer
            AddTestProp(productId, "ProcessorRuler", "Corei7"); // ProcessorRuler
            AddTestProp(productId, "CountCore", "4"); // CountCore
            AddTestProp(productId, "GraphicsType", "Integrated"); // GraphicsType
            AddTestProp(productId, "VideoMemorySize", "-"); // VideoMemorySize
            AddTestProp(productId, "Resolution", "3300x2200"); // Resolution
            AddTestProp(productId, "RAM", "16"); // RAM
            AddTestProp(productId, "InternalStorage", "SSD"); // VideoMemorySize
            AddTestProp(productId, "Storage", "1024 SSD"); // opt

            productId = AddTestProduct("Gigabyte AERO 15 OLED KD (KD-72RU624SD) Black", "Core i7 8 Core RAM 16Gb 1024 SSD", 61199,
                "https://img.telemart.ua/368465-512896/gigabyte-aero-15-oled-kd-kd-72ru624sd-black.png", "Laptop");
            AddTestGropReview(productId); // Review group
            AddTestProp(productId, "Manufacturer", "Gigabyte"); // Manufacturer
            AddTestProp(productId, "ProcessorRuler", "Corei7"); // ProcessorRuler
            AddTestProp(productId, "CountCore", "8"); // CountCore
            AddTestProp(productId, "GraphicsType", "Discrete"); // GraphicsType
            AddTestProp(productId, "VideoMemorySize", "6 ГБ"); // VideoMemorySize
            AddTestProp(productId, "Resolution", "UltraHD"); // Resolution
            AddTestProp(productId, "RAM", "16"); // RAM
            AddTestProp(productId, "InternalStorage", "SSD"); // VideoMemorySize
            AddTestProp(productId, "Storage", "1024 SSD"); // opt
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
