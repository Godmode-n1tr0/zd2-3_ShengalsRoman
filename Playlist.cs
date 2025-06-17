using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_Shengals_Roman
{
    public struct Song
    {
        public string Author;
        public string Title;
        public string Filename;

        public override string ToString()
        {
            return $"{Author} - {Title}";
        }
    }

    public class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        // Инициализация плейлиста
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        // Получить текущую песню
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        // Добавить песню (версия 1)
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        // Добавить песню (версия 2)
        public void AddSong(string author, string title, string filename)
        {
            list.Add(new Song { Author = author, Title = title, Filename = filename });
        }

        // Следующая песня
        public void Next()
        {
            if (list.Count == 0) return;
            currentIndex = (currentIndex + 1) % list.Count;
        }

        // Предыдущая песня
        public void Previous()
        {
            if (list.Count == 0) return;
            currentIndex = (currentIndex - 1 + list.Count) % list.Count;
        }

        // Перейти к песне по индексу
        public void GoToIndex(int index)
        {
            if (index >= 0 && index < list.Count)
                currentIndex = index;
        }

        // Перейти к началу
        public void GoToStart()
        {
            currentIndex = 0;
        }

        // Удалить песню по индексу
        public void RemoveSong(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                if (currentIndex >= list.Count && list.Count > 0)
                    currentIndex = list.Count - 1;
            }
        }

        // Удалить песню по значению
        public void RemoveSong(Song song)
        {
            int index = list.FindIndex(s => s.Author == song.Author && s.Title == song.Title && s.Filename == song.Filename);
            if (index >= 0)
            {
                list.RemoveAt(index);
                if (currentIndex >= list.Count && list.Count > 0)
                    currentIndex = list.Count - 1;
            }
        }

        // Очистить плейлист
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }

        // Получить все песни
        public List<Song> GetAllSongs()
        {
            return new List<Song>(list);
        }
    }
}
