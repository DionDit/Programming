using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayList.Models
{
    /// <summary>
    /// Управление файловым хранилищем
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Сохранение данных в файл data.json
        /// </summary>
        public static void SaveChanges()
        {
            File.WriteAllText("data.json",Song.CreateJSON(Song.Songs));
        }

        /// <summary>
        /// Получение данных из файла data.json
        /// </summary>
        public static void ReadFile()
        {
            if (File.Exists("data.json"))
            {
                Song.Songs = Song.CreateSongFromJSON(File.ReadAllText("data.json"));
            }
            else
            {
                File.Create("data.json");
            }
        }
    }
}
