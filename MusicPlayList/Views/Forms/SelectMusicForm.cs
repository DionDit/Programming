using MusicPlayList.Models;
using MusicPlayList.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList.Views.Forms
{
    public partial class SelectMusicForm : Form
    {
        private List<Song> Songs { get; set; }
        public SelectMusicForm(List<Song> songs)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Songs = songs;
            InitializeComponent();

            Songs.ForEach(x =>
            {
                flowLayoutPanel1.Controls.Add(new SelectedSongControl(x,"create"));
            });
        }

        private void SelectMusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicPlayer.StopMusic();
            FileManager.SaveChanges();
        }
    }
}
