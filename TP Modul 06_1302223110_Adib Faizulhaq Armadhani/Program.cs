using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_06_1302223110_Adib_Faizulhaq_Armadhani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract-Adib Faizulhaq Armadhani");
            video.increasePlayCount(8);
            video.printVideoDetails();

        }
    }
}
