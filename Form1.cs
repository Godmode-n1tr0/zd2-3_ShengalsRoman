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
            UpdateProductsList();
            UpdatePlaylistDisplay();
        }

        // Инициализация начальных данных магазина
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

        // Обновление списка товаров в интерфейсе
        private void UpdateProductsList()
        {
            productsListBox.Items.Clear();
            foreach (var item in shop.GetAllProducts())
            {
                productsListBox.Items.Add($"{item.Key.Name} - {item.Key.Price} руб. (Остаток: {item.Value})");
            }
            profitLabel.Text = $"Прибыль: {shop.Profit} руб.";
        }

        // Переключение на вкладку магазина
        private void Quest2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            UpdateProductsList();
        }

        // Переключение на вкладку плейлиста
        private void Quest3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            UpdatePlaylistDisplay();
        }

        // Продажа нескольких товаров
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

        // Добавление нового товара в магазин
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

        // Продажа одного товара
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

        // Обновление отображения плейлиста
        private void UpdatePlaylistDisplay()
        {
            playlistListBox.Items.Clear();
            var songs = playlist.GetAllSongs();

            foreach (var song in songs)
            {
                playlistListBox.Items.Add($"{song.Author} - {song.Title}");
            }

            try
            {
                var current = playlist.CurrentSong();
                lblCurrentSong.Text = $"Сейчас играет: {current.Author} - {current.Title}";
            }
            catch
            {
                lblCurrentSong.Text = "Плейлист пуст";
            }
        }

        // Добавление новой песни в плейлист
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

        // Переход к песне по указанному индексу
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

        // Удаление выбранной песни
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedIndex >= 0)
            {
                try
                {
                    playlist.RemoveSong(playlistListBox.SelectedIndex);

                    // Сохранение изменений в текущий файл
                    if (!string.IsNullOrEmpty(playlist.CurrentFilePath))
                    {
                        playlist.SaveChanges();
                    }

                    UpdatePlaylistDisplay();
                    MessageBox.Show("Песня удалена из плейлиста" +
                                    (!string.IsNullOrEmpty(playlist.CurrentFilePath) ? " и файла" : "", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Очистка плейлиста
        private void btnClearPlaylist_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            UpdatePlaylistDisplay();
        }

        // Сохранение плейлиста в файл
        private void btnSavePlaylist_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveDialog.Title = "Сохранить плейлист";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    playlist.SaveToFile(saveDialog.FileName);
                    MessageBox.Show("Плейлист успешно сохранен", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Загрузка плейлиста из файла
        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openDialog.Title = "Загрузить плейлист";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    playlist.LoadFromFile(openDialog.FileName);
                    UpdatePlaylistDisplay();
                    MessageBox.Show("Плейлист успешно загружен", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
