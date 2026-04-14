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
            Random random = new Random();
            this.id = random.Next(10000, 99999); // 5 digit random
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int amount)
        {
            playCount += amount;
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
