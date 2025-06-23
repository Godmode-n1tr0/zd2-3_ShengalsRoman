using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_Shengals_Roman
{
    public struct Song
    {
        public string Author;  // Исполнитель песни
        public string Title;   // Название песни
        public string Filename; // Путь к файлу

        public override string ToString()
        {
            return $"{Author} - {Title}";
        }
    }

    public class Playlist
    {
        private List<Song> list = new List<Song>();  // Список песен
        private int currentIndex;                    // Текущий индекс
        public string CurrentFilePath { get; private set; } // Текущий файл плейлиста

        // Получение текущей песни
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            throw new IndexOutOfRangeException("Плейлист пуст");
        }

        // Добавление новой песни
        public void AddSong(string author, string title, string filename)
        {
            if (string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Автор и название песни обязательны");

            list.Add(new Song { Author = author, Title = title, Filename = filename });
        }

        // Переход к следующей песне
        public void Next()
        {
            if (list.Count == 0) return;
            currentIndex = (currentIndex + 1) % list.Count;
        }

        // Переход к предыдущей песне
        public void Previous()
        {
            if (list.Count == 0) return;
            currentIndex = (currentIndex - 1 + list.Count) % list.Count;
        }

        // Переход к песне по индексу
        public void GoToIndex(int index)
        {
            if (index >= 0 && index < list.Count)
                currentIndex = index;
            else
                throw new IndexOutOfRangeException("Недопустимый индекс");
        }

        // Удаление песни по индексу
        public void RemoveSong(int index)
        {
            if (index < 0 || index >= list.Count)
                throw new IndexOutOfRangeException("Недопустимый индекс");

            list.RemoveAt(index);
            if (currentIndex >= list.Count && list.Count > 0)
                currentIndex = list.Count - 1;
        }

        // Очистка плейлиста
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }

        // Получение всех песен
        public List<Song> GetAllSongs()
        {
            return new List<Song>(list);
        }

        // Сохранение плейлиста в файл
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Song song in list)
                {
                    writer.WriteLine($"{song.Author}|{song.Title}|{song.Filename}");
                }
            }
            CurrentFilePath = filePath;
        }

        // Загрузка плейлиста из файла
        public void LoadFromFile(string filePath)
        {
            list.Clear();
            currentIndex = 0;
            CurrentFilePath = filePath;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    list.Add(new Song
                    {
                        Author = parts[0].Trim(),
                        Title = parts[1].Trim(),
                        Filename = parts[2].Trim()
                    });
                }
            }
        }

        // Сохранение изменений в текущий файл
        public void SaveChanges()
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
                throw new InvalidOperationException("Файл плейлиста не указан");

            SaveToFile(CurrentFilePath);
        }
    }
}
