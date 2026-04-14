using System;
using System.Collections.Generic;
using System.Text;

namespace Aurel_Adestira_Salsabila_Modul6_103082400041
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999); 
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
                total += video.PlayCount;
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
            }
        }
    }
}
