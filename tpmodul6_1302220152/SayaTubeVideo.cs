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
            // kondisi kondisi
            if (title is null || title.Length > 100) 
            {
                throw new ArgumentException("title tidak boleh null dan tidak boleh lebih dari 100 karakter");
            }


            this.title = title;

            var rd = new Random();
            id = rd.Next(10000, 99999);

            playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            checked
            {
                if (playCount > 10000000) throw new ArgumentException("playcount input harus lebih kecil dari 10000000");
                try
                {
                    this.playCount += playCount;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);   
                                                    
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Id: {id}\nJudul: {title}\nviews: {playCount}");
        }
    }
}
