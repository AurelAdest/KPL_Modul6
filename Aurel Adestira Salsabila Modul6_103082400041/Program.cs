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

            string[] films = {
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
        }
    }
}