using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList.Models
{
    /// <summary>
    /// Парсер музыки с сайта ru.drivemusic.me
    /// </summary>
    public static class MusicParser
    {
        /// <summary>
        /// Получение списка музыки
        /// </summary>
        /// <param name="SongName"></param>
        /// <returns></returns>
        public static async Task<List<Song>> GetSongs(string SongName)
        {
            List<Song> Result = new List<Song>();
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                var Data = await Task.Run(() => web.DownloadStringTaskAsync(new Uri($"https://ru.drivemusic.me/?do=search&subaction=search&story={SongName}")));
                MatchCollection Name = Regex.Matches(Data, $"class=\"popular-play-author\">(.*?)</a>");

                MatchCollection URL = Regex.Matches(Data, $"<div class=\"popular-play-name\"><a href=\"(.*?)\" class=\"popular-play-author\">(.*?)");
                List<string> Artist = new List<string>();
                List<string> Duration = new List<string>();
                List<string> Genre = new List<string>();
                MatchCollection MusicPlay = Regex.Matches(Data, $"<button aria-label=\"Воспроизвести\" data-url=\"(.*?).mp3\"");

                for (int i = 0; i < URL.Count; i++)
                {
                    Data = await Task.Run(() => web.DownloadStringTaskAsync(new Uri($"https://ru.drivemusic.me{URL[i].Groups[1].Value}")));

                    Match artist = Regex.Match(Data, "<h1 class=\"song-title-text\">(.*?)</h1>");
                    Artist.Add(artist.Groups[1].Value.Split(new char[] { '-' })[0]);
                    Match duration = Regex.Match(Data, "<li class=\"author-description-item\">(.*?) kbps, (.*?), (.*?)</li>");
                    Duration.Add(duration.Groups[3].Value);
                    Match genre = Regex.Match(Data, "<li class=\"author-description-item\">(.*?): <a href=\"(.*?)\" class=\"table-author\">(.*?)</a></li>");
                    Genre.Add(genre.Groups[3].Value);
                    int SecondDuration = Convert.ToInt32(Duration[i].Split(new char[] { ':' })[0]) * 60 + Convert.ToInt32(Duration[i].Split(new char[] { ':' })[1]);
                    Result.Add(new Song(Name[i].Groups[1].Value, Artist[i], SecondDuration, Genre[i], null, $"{MusicPlay[i].Groups[1].Value}.mp3"));
                }
            }
            return Result;
        }
    }
}
