using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_Shengals_Roman
{
    class Product
    {
        // Свойства товара
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Конструктор товара с проверками
        public Product(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название товара не может быть пустым");

            if (price <= 0)
                throw new ArgumentException("Цена должна быть положительной");

            Name = name;
            Price = price;
        }

        // Метод для получения информации о товаре
        public string GetInfo()
        {
            return $"{Name} - {Price} руб.";
        }

        // Переопределение для удобного вывода
        public override string ToString()
        {
            return GetInfo();
        }

    }
}
