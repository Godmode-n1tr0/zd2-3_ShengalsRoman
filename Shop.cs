using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_Shengals_Roman
{
    class Shop
    {
        private Dictionary<Product, int> products = new Dictionary<Product, int>();

        private const int MAX_PRODUCT_QUANTITY = 1000;
        private const decimal MAX_PRODUCT_PRICE = 10000;

        public decimal Profit { get; private set; } = 0;

        // Добавление товара с проверками
        public void AddProduct(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            ValidateProduct(product, quantity);

            if (products.Keys.Any(p => p.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
                throw new ArgumentException($"Товар '{product.Name}' уже существует");

            products.Add(product, quantity);
        }

        // Создание и добавление товара
        public void CreateProduct(string name, decimal price, int quantity)
        {
            Product product = new Product(name, price);
            AddProduct(product, quantity);
        }

        // Продажа товара (по объекту)
        public bool Sell(Product product, int quantity = 1)
        {
            if (!products.ContainsKey(product))
                return false;

            if (products[product] < quantity)
                return false;

            products[product] -= quantity;
            Profit += product.Price * quantity;

            if (products[product] == 0)
                products.Remove(product);

            return true;
        }

        // Продажа товара по имени
        public bool Sell(string productName, int quantity = 1)
        {
            Product product = FindByName(productName);
            return product != null && Sell(product, quantity);
        }

        // Продажа нескольких товаров
        public bool SellMultiple(Dictionary<string, int> productsToSell)
        {
            if (productsToSell == null || productsToSell.Count == 0)
                return false;

            foreach (var item in productsToSell)
            {
                Product product = FindByName(item.Key);
                if (product == null || products[product] < item.Value)
                    return false;
            }

            foreach (var item in productsToSell)
            {
                Sell(item.Key, item.Value);
            }

            return true;
        }

        // Поиск товара по имени
        public Product FindByName(string name)
        {
            return products.Keys.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Получение всех товаров
        public Dictionary<Product, int> GetAllProducts()
        {
            return new Dictionary<Product, int>(products);
        }

        // Валидация товара
        private void ValidateProduct(Product product, int quantity)
        {
            if (quantity <= 0 || quantity > MAX_PRODUCT_QUANTITY)
                throw new ArgumentException($"Количество должно быть от 1 до {MAX_PRODUCT_QUANTITY}");

            if (product.Price > MAX_PRODUCT_PRICE)
                throw new ArgumentException($"Цена не может превышать {MAX_PRODUCT_PRICE} руб.");
        }
    }
}
