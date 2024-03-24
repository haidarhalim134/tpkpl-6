namespace tpmodul6_1302220152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tidak error");
            var vid = new SayaTubeVideo("Tutorial Design By Contract - [Haidar_Abdul_Halim]");
            vid.PrintVideoDetails();

            Console.WriteLine("title terlalu panjang");
            try
            {
                var vid1 = new SayaTubeVideo(string.Concat(Enumerable.Repeat("ab", 60)));
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.WriteLine("playcount");
            for (int i = 0;i < 100000; i++)
            {
                vid.IncreasePlayCount(i*1000);
            }
        }
    }
}
