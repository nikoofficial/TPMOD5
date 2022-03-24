using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace tpmodul5_1302204050
{
    public class SayaTubeVideo
    {

        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();

            for (int i = 0; i < title.Length; i++)
            {
                id = random.Next();
            }
        }


        public void IncreasePlayCount(int playCount)
        {
            public void IncreasePlayCount(int count)
            {
                try
                {
                    if (count >= 10000000) throw new Exception("Input Melebihi 10.000.000!");
                    playCount = playCount + count;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        public static void PrintVideoDetails(int id, string title, int playCount)
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);

        }


    }
}