using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302220152
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;

            var rd = new Random();
            id = rd.Next(10000, 99999);

            playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Id: {id}\nJudul: {title}\nviews: {playCount}");
        }
    }
}
