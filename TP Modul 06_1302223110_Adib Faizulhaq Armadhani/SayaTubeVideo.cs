using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_06_1302223110_Adib_Faizulhaq_Armadhani
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        internal SayaTubeVideo(string videoTitle)
        {
            title = videoTitle;

            playCount = 0;

            id = new Random().Next(10000, 99999);
        }

        public void increasePlayCount(int play)
        {
            playCount += play;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Id vidio: " + id);
            Console.WriteLine("Play Count: " + playCount);

        }
    }
}
