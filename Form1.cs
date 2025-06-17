using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_3_Shengals_Roman
{
    public partial class Form1 : Form
    {
        private Shop shop = new Shop();
        private Playlist playlist = new Playlist();

        public Form1()
        {
            InitializeComponent();
            InitializeShop();
            panel1.Visible = true;
            panel3.Visible = false;
            LoadPlaylistsFromFile("playlist.txt");
            UpdateProductsList();
            UpdatePlaylistDisplay();
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
            UpdatePlaylistDisplay();
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




        //Загрузка файла
        private void LoadPlaylistsFromFile(string filePath)
        {
            try
            {
                string currentPlaylist = "";
                foreach (string line in File.ReadAllLines(filePath))
                {
                    if (line.StartsWith("#"))
                    {
                        currentPlaylist = line.Substring(2);
                        continue;
                    }

                    if (!string.IsNullOrEmpty(line) && !string.IsNullOrEmpty(currentPlaylist))
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 4)
                        {
                            string[] artistTitle = parts[0].Split('-');
                            if (artistTitle.Length == 2)
                            {
                                playlist.AddSong(
                                    artistTitle[0].Trim(),
                                    artistTitle[1].Trim(),
                                    parts[3].Trim());
                            }
                        }
                    }
                }
                UpdatePlaylistDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки плейлистов: {ex.Message}");
            }
        }
        // Обновление плэйлиста
        private void UpdatePlaylistDisplay()
        {
            playlistListBox.Items.Clear();
            foreach (var song in playlist.GetAllSongs())
            {
                playlistListBox.Items.Add(song);
            }

            try
            {
                lblCurrentSong.Text = playlist.CurrentSong().ToString();
            }
            catch (IndexOutOfRangeException)
            {
                lblCurrentSong.Text = "Плейлист пуст";
            }
        }

        // Добавление песни
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.AddSong(txtAuthor.Text, txtTitle.Text, txtFilename.Text);
                UpdatePlaylistDisplay();
                txtAuthor.Clear();
                txtTitle.Clear();
                txtFilename.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        // Переход к следующей песне
        private void btnNext_Click(object sender, EventArgs e)
        {
            playlist.Next();
            UpdatePlaylistDisplay();
        }

        // Переход к предыдущей песне
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            playlist.Previous();
            UpdatePlaylistDisplay();
        }

        // Переход по индексу
        private void btnGoToIndex_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.GoToIndex((int)numericUpDownIndex.Value);
                UpdatePlaylistDisplay();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        // Переход к началу плейлиста
        private void btnGoToStart_Click(object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdatePlaylistDisplay();
        }

        // Удаление выбранной песни
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedIndex >= 0)
            {
                playlist.RemoveSong(playlistListBox.SelectedIndex);
                UpdatePlaylistDisplay();
            }
        }

        // Очистка плейлиста
        private void btnClearPlaylist_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            UpdatePlaylistDisplay();
        }

    }
}
