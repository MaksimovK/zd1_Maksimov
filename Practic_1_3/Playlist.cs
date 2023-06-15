using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practic_1_3
{
    public class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        public void AddSong(string author, string title, string filename)
        {
            Song song = new Song
            {
                Author = author,
                Title = title,
                Filename = filename
            };
            list.Add(song);
        }

        public void NextSong()
        {
            currentIndex++;
            if (currentIndex >= list.Count)
                currentIndex = 0;
        }

        public void PreviousSong()
        {
            currentIndex--;
            if (currentIndex < 0)
                currentIndex = list.Count - 1;
        }

        public void GoToSong(int index)
        {
            if (index >= 0 && index < list.Count) currentIndex = index;
            else MessageBox.Show("Неверный индекс аудиозаписи", "Ошибка");
        }

        public void GoToStart()
        {
            currentIndex = 0;
        }

        public void RemoveSong(int index)
        {
            if (index >= 0 && index < list.Count) list.RemoveAt(index);
            else MessageBox.Show("Неверный индекс аудиозаписи", "Ошибка");
        }

        public void RemoveSong(Song song)
        {
            int index = list.FindIndex(s => s.Equals(song));
            if (index != -1) list.RemoveAt(index);
        }

        public void ClearPlaylist()
        {
            list.Clear();
            currentIndex = 0;
        }
    }
}