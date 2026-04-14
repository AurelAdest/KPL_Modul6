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
            // precondition username tidak boleh null
            if (username == null)
                throw new ArgumentNullException("username", "Username tidak boleh null.");

            // precondition username maksimal 100 karakter
            if (username.Length > 100)
                throw new ArgumentException("Username maksimal 100 karakter.");

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
            //precondition video tidak boleh null
            if (video == null)
                throw new ArgumentNullException("video", "Video yang ditambahkan tidak boleh null.");

            //precondition playCount video harus kurang dari int.MaxValue
            if (video.PlayCount >= int.MaxValue)
                throw new ArgumentException("Video yang ditambahkan punya playCount yang sudah mencapai batas integer.");

            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");

            // postcondition maksimal 8 video yang di-print
            int maxPrint = Math.Min(uploadedVideos.Count, 8);

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
            }
        }
    }
}
