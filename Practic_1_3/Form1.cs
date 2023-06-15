using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_1_3
{
    public partial class Form1 : Form
    {
        private Playlist playlist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlist = new Playlist();
        }

        private void bt_addSong_Click(object sender, EventArgs e)
        {
            string author = tb_Author.Text;
            string title = tb_Title.Text;
            string filename = tb_Filename.Text;

            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Для добавления песни, заполните все поля!", "Внимание!");
                return;
            }

            playlist.AddSong(author, title, filename);

            tb_Author.Clear();
            tb_Title.Clear();
            tb_Filename.Clear();

            MessageBox.Show("Композиция была добавлена!", "Отлично!");
        }

        
        private void bt_next_Click_1(object sender, EventArgs e)
        {
            playlist.NextSong();
            UpdateCurrentSong();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            playlist.PreviousSong();
            UpdateCurrentSong();
        }
        private void UpdateCurrentSong()
        {
            try
            {
                Song currentSong = playlist.CurrentSong();
                authorLabel.Text = currentSong.Author;
                titleLabel.Text = currentSong.Title;
                filenameLabel.Text = currentSong.Filename;
            }
            catch (IndexOutOfRangeException)
            {
                authorLabel.Text = string.Empty;
                titleLabel.Text = string.Empty;
                filenameLabel.Text = string.Empty;
            }
        }

        private void bt_GoToStart_Click(object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdateCurrentSong();
        }

        private void bt_ClearPlaylist_Click(object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            UpdateCurrentSong();
        }

        private void bt_GoToIndex_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_index.Text, out int index))
            {
                try
                {
                    playlist.GoToSong(index);
                    UpdateCurrentSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }

        private void bt_removeSong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_index.Text, out int index))
            {
                try
                {
                    playlist.RemoveSong(index);
                    UpdateCurrentSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }
    }
}
