using System;
using System.Collections.Generic;
using System.Text;

namespace Aurel_Adestira_Salsabila_Modul6_103082400041
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Aurel");

            string[] films =
            {
                "Review Film Jumbo oleh Aurel",
                "Review Film Agak Laen oleh Aurel",
                "Review Film Agak Laen 2 oleh Aurel",
                "Review Film Danur 1 oleh Aurel",
                "Review Film Danur 2 oleh Aurel",
                "Review Film Sore istri dari masa depan oleh Aurel",
                "Review Film Frozen oleh Aurel",
                "Review Film Senin harga naik oleh Aurel",
                "Review Film Komang oleh Aurel",
                "Review Film Mati rasa oleh Aurel"
            };

            Console.WriteLine("DETAIL SEMUA VIDEO");
            foreach (string film in films)
            {
                SayaTubeVideo video = new SayaTubeVideo(film);
                video.IncreasePlayCount(1000);
                video.PrintVideoDetails();
                user.AddVideo(video);
            }

            Console.WriteLine("\nSEMUA VIDEO MILIK USER ");
            user.PrintAllVideoPlaycount();

            Console.WriteLine("\nTOTAL PLAY COUNT USER ");
            Console.WriteLine($"Total seluruh play count: {user.GetTotalVideoPlayCount()}");

            Console.WriteLine("\nUJI PRECONDITION");

            // uji judul null
            Console.WriteLine("\n[1] Judul video null:");
            try
            {
                SayaTubeVideo v = new SayaTubeVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji judul lebih dari 200 karakter
            Console.WriteLine("\n[2] Judul video lebih dari 200 karakter:");
            try
            {
                SayaTubeVideo v = new SayaTubeVideo(new string('A', 201));
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji play count negatif
            Console.WriteLine("\n[3] Play count negatif:");
            try
            {
                SayaTubeVideo v = new SayaTubeVideo("Video Test");
                v.IncreasePlayCount(-5);
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji play count lebih dari 25 juta
            Console.WriteLine("\n[4] Play count melebihi 25.000.000:");
            try
            {
                SayaTubeVideo v = new SayaTubeVideo("Video Test");
                v.IncreasePlayCount(30_000_000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji username null
            Console.WriteLine("\n[5] Username null:");
            try
            {
                SayaTubeUser u = new SayaTubeUser(null);
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji username lebih dari 100 karakter
            Console.WriteLine("\n[6] Username lebih dari 100 karakter:");
            try
            {
                SayaTubeUser u = new SayaTubeUser(new string('B', 101));
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            // uji video null di AddVideo
            Console.WriteLine("\n[7] Video null ditambahkan ke user:");
            try
            {
                SayaTubeUser u = new SayaTubeUser("TestUser");
                u.AddVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine($"    ERROR tertangkap -> {e.Message}");
            }

            Console.WriteLine("\nUJI EXCEPTION (OVERFLOW)");
            SayaTubeVideo overflowVideo = new SayaTubeVideo("Video Overflow Tes");
            for (int i = 0; i < 200; i++)
            {
                overflowVideo.IncreasePlayCount(25_000_000);
            }

            Console.WriteLine("\nUJI POSTCONDITION (max 8 video terprint)");
            Console.WriteLine("User punya 10 video, tapi yang terprint hanya 8:");
            user.PrintAllVideoPlaycount();
        }
    }
}