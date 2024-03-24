using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223116
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String tube)
        {
            Debug.Assert(tube.Length < 200);
            Debug.Assert(!string.IsNullOrEmpty(tube));
            Random random = new Random();
            this.title = tube;
            this.id = random.Next(100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000);
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah Pemutaran: {playCount}");
        }
    }
}
