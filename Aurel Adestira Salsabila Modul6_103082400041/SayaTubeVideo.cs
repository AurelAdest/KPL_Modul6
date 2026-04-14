using System;
using System.Collections.Generic;
using System.Text;

namespace Aurel_Adestira_Salsabila_Modul6_103082400041
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // precondition judul tidak boleh null
            if (title == null)
                throw new ArgumentNullException("title", "Judul video tidak boleh null.");

            // precondition judul maksimal 200 karakter
            if (title.Length > 200)
                throw new ArgumentException("Judul video maksimal 200 karakter.");
            Random random = new Random();
            this.id = random.Next(10000, 99999); // 5 digit random
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int amount)
        {
            // precondition tidak boleh negatif
            if (amount < 0)
                throw new ArgumentException("Penambahan play count tidak boleh bilangan negatif.");

            // precondition maksimal 25.000.000 per pemanggilan
            if (amount > 25_000_000)
                throw new ArgumentException("Penambahan play count maksimal 25.000.000 per pemanggilan.");

            // exception cek overflow dengan keyword checked
            try
            {
                playCount = checked(playCount + amount);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"[OVERFLOW ERROR] PlayCount video '{title}' melebihi batas integer! Penambahan dibatalkan.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID    : {id}");
            Console.WriteLine($"Judul : {title}");
            Console.WriteLine($"Play  : {playCount}");
            Console.WriteLine("\n");
        }

        public int PlayCount => playCount;
        public string Title => title;
    }
}
