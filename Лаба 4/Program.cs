using System;
using System.Media;
namespace Лаба_4
{

    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(@"Lab4.wav");
            player.Play();
            Console.ReadKey();
        }
    }
}

