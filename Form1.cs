using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_3_Shengals_Roman
{
    public partial class Form1 : Form
    {
        private Shop shop = new Shop();

        public Form1()
        {
            InitializeComponent();
            InitializeShop();

            panel1.Visible = true;
            panel3.Visible = false;
            UpdateProductsList();
        }

        private void InitializeShop()
        {
            try
            {
                shop.CreateProduct("Кола", 85, 50);
                shop.CreateProduct("Сок Добрый", 100, 30);
                shop.CreateProduct("Хлеб", 45, 20);
                shop.CreateProduct("Молоко", 75, 40);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации: {ex.Message}");
            }
        }
        // Обновление списка товаров
        private void UpdateProductsList()
        {
            productsListBox.Items.Clear();
            foreach (var item in shop.GetAllProducts())
            {
                productsListBox.Items.Add($"{item.Key.Name} - {item.Key.Price} руб. (Остаток: {item.Value})");
            }
            profitLabel.Text = $"Прибыль: {shop.Profit} руб.";
        }
        // Показ 2 задания
        private void Quest2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            UpdateProductsList();
        }
        // Показ 3 задания
        private void Quest3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
        }
        // Обработчик кнопки "Продать выбранные"
        private void BtnSellMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProducts = productsListBox.SelectedItems;

                if (selectedProducts.Count == 0)
                {
                    MessageBox.Show("Выберите товары для продажи", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var productsToSell = new Dictionary<string, int>();
                int quantity = (int)numericUpDownQuantity.Value;

                foreach (var item in selectedProducts)
                {
                    string productInfo = item.ToString();
                    string productName = productInfo.Split('-')[0].Trim();
                    productsToSell.Add(productName, quantity);
                }

                if (shop.SellMultiple(productsToSell))
                {
                    UpdateProductsList();
                    MessageBox.Show($"Продано {productsToSell.Count} товаров по {quantity} шт.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при продаже. Проверьте наличие товаров.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Обработчик кнопки "Добавить"
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                    throw new ArgumentException("Введите название товара");

                if (!decimal.TryParse(PriceTextBox.Text, out decimal price) || price <= 0)
                    throw new ArgumentException("Введите корректную цену");

                if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity <= 0)
                    throw new ArgumentException("Введите корректное количество");

                shop.CreateProduct(NameTextBox.Text, price, quantity);
                UpdateProductsList();

                NameTextBox.Clear();
                PriceTextBox.Clear();
                QuantityTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка добавления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка продажи одиночная
        private void SellButton_Click_1(object sender, EventArgs e)
        {
            if (productsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар для продажи");
                return;
            }

            string selectedItem = productsListBox.SelectedItem.ToString();
            string productName = selectedItem.Split('-')[0].Trim();

            if (shop.Sell(productName))
            {
                UpdateProductsList();
                MessageBox.Show($"Товар {productName} продан");
            }
            else
            {
                MessageBox.Show("Не удалось продать товар. Проверьте наличие.");
            }
        }

    }
}
