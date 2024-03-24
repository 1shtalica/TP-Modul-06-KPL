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
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract-Adib Faizulhaq Armadhani");

                for (int i = 5 - 1; i >= 0; i--)
                {
                    video.increasePlayCount(300000000);
                }

                video.printVideoDetails();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
